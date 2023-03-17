using UnityEngine;

[RequireComponent(typeof(VelocityController), typeof(CapsuleCollider))]
public class PlayerRoll : MonoBehaviour
{
    private VelocityController cached_velocityController;
    private VelocityController VelocityController => cached_velocityController ??= GetComponent<VelocityController>();

    private Animator cached_Animator;
    private Animator Animator => cached_Animator ??= GetComponentInChildren<Animator>();

    private CapsuleCollider cached_CapsuleCollider;
    private CapsuleCollider CapsuleCollider => cached_CapsuleCollider ??= GetComponent<CapsuleCollider>();
    private const float STANDING_HEIGHT = 2f;
    private const float ROLLING_HEIGHT = 1f;

    private bool m_rollBuffer;
    private bool m_rollInput;
    public bool Rolling { get => m_rollBuffer; set => m_rollBuffer |= (m_rollInput = value); }

    private Vector2 m_RollDirection;
    public Vector2 RollDirection { get => m_RollDirection; set => m_RollDirection = value.magnitude > 0.1f ? value.normalized : m_RollDirection; }
    public Vector2 AbsoluteRollDirection => Quaternion.Euler(0, 0, -cameraOrbit?.transform.eulerAngles.y ?? 0) * RollDirection;
    [SerializeField] private OrbitCameraController cameraOrbit;
    public const int VELOCITY_OVERWRITE_PRIORITY = 10;

    public bool InRoll => lastRollTime + rollDuration > Time.time;

    public float rollDuration = .5f;
    public float postRollCooldown = .2f;
    public AnimationCurve speedCurve = AnimationCurve.Constant(0, 1, 1);
    private float SpeedCurveIntegral
    {
        get
        {
            var areaUnderCurve = 0f;
            var step = Time.fixedDeltaTime / rollDuration;
            for (float t = 0; t < 1; t += step)
                areaUnderCurve += speedCurve.Evaluate(t);
            areaUnderCurve *= step;
            return areaUnderCurve;
        }
    }
    public float distance = 1.5f;

    private float lastRollTime = -1;
    private void FixedUpdate()
    {
        CapsuleCollider.height = InRoll ? ROLLING_HEIGHT : STANDING_HEIGHT;
        CapsuleCollider.center = Vector3.up * CapsuleCollider.height / 2f;

        if (!Rolling) return;
        m_rollBuffer = m_rollInput;

        //Check Cooldown
        if (lastRollTime + rollDuration + postRollCooldown > Time.time) return;

        Animator.SetTrigger("Slide");

        //ApplyRoll        
        var integral = SpeedCurveIntegral;
        var averageSpeed = distance / rollDuration;
        VelocityController.AddOverwriteMovement(new(AbsoluteRollDirection._x0y().normalized, t => SpeedFunction(t) / integral * averageSpeed), rollDuration, VELOCITY_OVERWRITE_PRIORITY);

        //Set Cooldown
        lastRollTime = Time.time;
    }

    private float SpeedFunction(float t)
    {
        return 1;
        //return speedCurve.Evaluate(t);
    }
}
