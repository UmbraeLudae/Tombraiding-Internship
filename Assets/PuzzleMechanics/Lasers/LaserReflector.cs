using System;
using System.Collections.Generic;
using UnityEngine;

public class LaserReflector : LaserEmitter, ILaserReciever
{
    private Dictionary<Laser, ILaserReciever> laserRecievers;
    public Vector2 Position => transform.position._xz();

    public void RecieveLaser(Laser laser)
    {
        var target = (ILaserReciever)null;
        ShootLaser(laser.WithDirection(Reflect(laser.direction)), ref target);
        laserRecievers.Add(laser, target);
    }

    public void StopRecievingLaser(Laser laser)
    {
        laserRecievers.Remove(laser);
    }

    private Vector2 Reflect(Vector2 direction) => Vector2.Reflect(direction, transform.forward._xz());
    void FixedUpdate()
    {
        foreach (var laser in laserRecievers.Keys)
        {
            var target = laserRecievers[laser];
            ShootLaser(laser.WithDirection(Reflect(laser.direction)), ref target);
            laserRecievers[laser] = target;
        }
    }
}