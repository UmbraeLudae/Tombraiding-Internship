

using UnityEngine;

public interface ILaserReciever
{
    Vector2 Position { get; }
    void RecieveLaser(Laser laser);
    void StopRecievingLaser(Laser laser);
}
