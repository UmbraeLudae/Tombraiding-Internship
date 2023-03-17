using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LaserRecieverTrigger : Trigger, ILaserReciever
{
    public override bool IsOn => lasers.Count > 0;
    public Vector2 Position => transform.position._xz();
    public override event Action<bool> OnChanged;
    private readonly HashSet<Laser> lasers = new();
    [SerializeField] private new MeshRenderer renderer;
    private Color emissionColor = new Color(3.20000005f, 0.423529416f, 1.09803927f, 1);

    void Start() => renderer.materials[1].SetColor("_EmissiveColor", IsOn ? emissionColor : Color.black);

    public void RecieveLaser(Laser laser)
    {
        lasers.Add(laser);
        if (lasers.Count == 1) OnChanged?.Invoke(true);
        renderer.materials[1].SetColor("_EmissiveColor", IsOn ? emissionColor : Color.black);
    }

    public void StopRecievingLaser(Laser laser)
    {
        lasers.Remove(laser);
        if (lasers.Count == 0) OnChanged?.Invoke(false);
        renderer.materials[1].SetColor("_EmissiveColor", IsOn ? emissionColor : Color.black);
    }
}
