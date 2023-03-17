using System;
using UnityEngine;

public abstract class Trigger : MonoBehaviour
{
    public abstract bool IsOn { get; }
    public abstract event Action<bool> OnChanged;
}
