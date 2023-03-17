using System;
using UnityEngine;

public class RotatingStatue : Trigger, IWhippable
{
    public Vector2 Position => gameObject.transform.position._xz();
    public override bool IsOn => m_isOn;
    private bool m_isOn;

    private int CurrentRotation => Mathf.RoundToInt(((transform.localEulerAngles.y + 360f) % 360f) / rotationStep);
    [SerializeField] private int targetRotation;
    private int MaxRotation => Mathf.FloorToInt(360 / rotationStep);

    [SerializeField] private float rotationStep = 45; //8 directions

    public override event Action<bool> OnChanged;

    void Start()
    {
        var shouldBeOn = CurrentRotation == targetRotation;
        if (m_isOn != shouldBeOn && ((m_isOn = shouldBeOn) || true))
            OnChanged?.Invoke(shouldBeOn);
    }

    public IWhippable.WhipInteraction OnWhip(GameObject whipper)
    {
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, ((CurrentRotation + 1) * rotationStep) % 360f, transform.localEulerAngles.z);
        var shouldBeOn = CurrentRotation == targetRotation;
        if (m_isOn != shouldBeOn && ((m_isOn = shouldBeOn) || true))
            OnChanged?.Invoke(shouldBeOn);
        return IWhippable.WhipInteraction.Consume;
    }
}
