
using UnityEngine;

public class TurnTowardsVelocity : MonoBehaviour
{
    VelocityController cached_VelocityController;
    VelocityController VelocityController => cached_VelocityController ??= GetComponentInParent<VelocityController>();

    PlayerMove cached_PlayerMove;
    PlayerMove PlayerMove => cached_PlayerMove ??= GetComponentInParent<PlayerMove>();

    PlayerRoll cached_PlayerRoll;
    PlayerRoll PlayerRoll => cached_PlayerRoll ??= GetComponentInParent<PlayerRoll>();

    private Vector2 dir = Vector2.up;

    void FixedUpdate()
    {
        
        var direction = PlayerRoll.InRoll ? VelocityController.CurrentVelocity._xz() : PlayerMove.MovementDirection;
        dir = direction.magnitude > 0.1f ? direction : dir;
        var angle = -Vector2.SignedAngle(Vector2.up, dir);
        var ry = Mathf.LerpAngle(transform.eulerAngles.y, angle, .4f);
        transform.localRotation = Quaternion.Euler(0, ry, 0);
    }
}
