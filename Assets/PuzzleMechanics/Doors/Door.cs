
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Door : MonoBehaviour
{
    private BoxCollider cached_Collider;
    private BoxCollider Collider => cached_Collider ??= GetComponent<BoxCollider>();

    public List<Trigger> triggers;
    public bool IsOpen { get; private set; }

    void OnEnable()
    {
        triggers.ForEach(trigger => trigger.OnChanged += OnTriggerChanged);
    }

    void OnTriggerChanged(bool value)
    {
        if (value == IsOpen) return; //can assume that nothing changed
        var shouldBeOpen = triggers.All(trigger => trigger.IsOn);
        if (IsOpen == shouldBeOpen) return;
        if (shouldBeOpen) Open();
        else Close();
    }

    void Open()
    {
        IsOpen = true;
        Collider.enabled = false;
    }

    void Close()
    {
        IsOpen = false;
        Collider.enabled = true;
    }

}
