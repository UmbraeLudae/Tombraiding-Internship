using System;
using UnityEngine;

public class SingleLaserEmitter : LaserEmitter
{
    private Guid laserGuid;
    private ILaserReciever currentTarget;

    private LineRenderer cached_lr;
    private LineRenderer lr => cached_lr ??= GetComponent<LineRenderer>();

    void FixedUpdate()
    {
        ShootLaser(new(laserGuid, transform.forward._xz()), ref currentTarget, out var wallhit);
        var target = currentTarget?.Position ?? wallhit._xz();
        lr.SetPositions(new[] { transform.position._x0z() + Vector3.up * LaserEmitter.LASER_HEIGHT, target._x0y() + Vector3.up * LaserEmitter.LASER_HEIGHT });
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        var dir = transform.forward._x0z();
        var start = transform.position._x0z() + Vector3.up * LaserEmitter.LASER_HEIGHT;
        Gizmos.DrawLine(start + dir * 100f, start);
    }
#endif
}
