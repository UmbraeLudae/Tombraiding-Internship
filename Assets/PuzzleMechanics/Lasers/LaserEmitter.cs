
using System.Linq;
using UnityEngine;

public abstract class LaserEmitter : MonoBehaviour
{
    public const float LASER_WIDTH = .05f;
    public const float LASER_HEIGHT = 1f;

    protected void ShootLaser(Laser laser, ref ILaserReciever laserTarget) => ShootLaser(laser, ref laserTarget, out var _);
    protected void ShootLaser(Laser laser, ref ILaserReciever laserTarget, out Vector3 wallHit)
    {
        var ray = new Ray(transform.position._x0z() + Vector3.up * LASER_HEIGHT, laser.direction._x0y());
        var laserHits = Physics.SphereCastAll(ray.origin, LASER_WIDTH, ray.direction, 100f, ~LayerMask.GetMask("Ignore Raycast")).OrderBy(hit => hit.distance).Where(hit => hit.collider.GetComponentInParent<LaserEmitter>() != this);
        var laserHit = laserHits.Count() > 0 ? laserHits.First() : (RaycastHit?)null;
        var hitReciever = laserHit?.collider.GetComponentInParent<ILaserReciever>();
        wallHit = laserHit?.point ?? ray.GetPoint(100f);
        if (hitReciever == laserTarget) return;
        laserTarget?.StopRecievingLaser(laser);
        hitReciever?.RecieveLaser(laser);
        laserTarget = hitReciever;
    }
}