using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(VelocityController))]
public class PlayerMove : MonoBehaviour
{
    private VelocityController cached_velocityController;
    private VelocityController VelocityController => cached_velocityController ??= GetComponent<VelocityController>();

    private Animator cached_Animator;
    private Animator Animator => cached_Animator ??= GetComponentInChildren<Animator>();

    [SerializeField] private OrbitCameraController cameraOrbit;

    public const int VELOCITY_OVERWRITE_PRIORITY = 0;

    public Vector2 InputDirection { get; set; }
    public Vector2 MovementDirection => Quaternion.Euler(0, 0, -cameraOrbit?.transform.eulerAngles.y ?? 0) * InputDirection;
    public float baseSpeed = 5;
    private readonly Dictionary<Guid, float> speedModifiers = new();

    private float MovementSpeed => speedModifiers.Values.Aggregate(baseSpeed, (x, y) => x * y);

    public Guid AddSpeedModifier(float modifier)
    {
        var key = Guid.NewGuid();
        speedModifiers.Add(key, modifier);
        return key;
    }
    public void RemoveSpeedModifier(Guid key) => speedModifiers.Remove(key);

    private void FixedUpdate()
    {
        var movement = MovementDirection._x0y();
        Animator.SetBool("Running", movement.magnitude > 0f);
        VelocityController.AddOverwriteMovement(new(movement, MovementSpeed, VelocityBlendMode.Overwrite), 0f, VELOCITY_OVERWRITE_PRIORITY);
    }
}
