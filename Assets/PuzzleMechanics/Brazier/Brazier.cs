using System;
using System.Collections.Generic;
using UnityEngine;

public class Brazier : Trigger, IWhippable, ILaserReciever
{
    public Vector2 Position => transform.position._xz();

    public override bool IsOn => Lit == requiredLit;
    [SerializeField] private bool m_lit = true;
    private bool Lit
    {
        get => m_lit;
        set
        {
            m_lit = value;
            foreach (var light in Lights)
                light.enabled = m_lit;
            coalRenderer.material.SetColor("_EmissiveColor", m_lit ? Color.white : Color.black);
        }
    }
    [SerializeField] private bool requiredLit = true;

    private Light[] cached_Lights;
    private Light[] Lights => cached_Lights ??= GetComponentsInChildren<Light>();
    [SerializeField] private MeshRenderer coalRenderer;

    public override event Action<bool> OnChanged;

    void OnEnable() => Lit = m_lit;

    public IWhippable.WhipInteraction OnWhip(GameObject whipper)
    {
        if (lasers.Count > 0) return IWhippable.WhipInteraction.Pass;
        if (Lit && ((Lit = false) || true)) OnChanged?.Invoke(IsOn); //turn light OFF and signal new trigger state        
        return IWhippable.WhipInteraction.Pass;
    }

    private readonly HashSet<Laser> lasers = new();
    public void RecieveLaser(Laser laser)
    {
        if (!Lit && (Lit = true)) OnChanged.Invoke(IsOn); //turn light ON and signal new trigger state
        foreach (var light in Lights)
            light.enabled = Lit;
        lasers.Add(laser);
    }
    public void StopRecievingLaser(Laser laser) { lasers.Remove(laser); }
}
