using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PressurePlate : Trigger
{
    private BoxCollider cached_BoxCollider;
    private BoxCollider BoxCollider => cached_BoxCollider ??= GetComponent<BoxCollider>();


    [SerializeField] private float RequiredWeight = 5f;
    
    public override bool IsOn => m_Pressed;
    private bool m_Pressed;

    private readonly HashSet<IWeightProvider> weightProviders = new();
    public override event Action<bool> OnChanged;

    private float TotalWeight => weightProviders.Sum(p => p.Weight);

    private void Start() => BoxCollider.isTrigger = true;

    void FixedUpdate()
    {
        if (weightProviders.Count == 0 && !IsOn) return;
        var shouldBeOn = TotalWeight >= RequiredWeight;
        if (IsOn == shouldBeOn) return;
        m_Pressed = shouldBeOn;
        OnChanged?.Invoke(IsOn);
    }

    public void OnTriggerStay(Collider other)
    {
        var weightProvider = other.GetComponent<IWeightProvider>();
        if (weightProvider == null) return;

        var center = other.bounds.center._x0z();
        if (!BoxCollider.bounds.Contains(center))
        {
            weightProviders.Remove(weightProvider);
            return;
        }
        weightProviders.Add(weightProvider);
    }

    public void OnTriggerExit(Collider other)
    {
        var weightProvider = other.GetComponent<IWeightProvider>();
        if (weightProvider == null) return;
        weightProviders.Remove(weightProvider);        
    }

}
