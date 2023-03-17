
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pullable : MonoBehaviour, IWhippable
{
    public const float RANGE = 2f;
    Rigidbody cached_Rigidbody;
    public Rigidbody Rigidbody => cached_Rigidbody ??= GetComponent<Rigidbody>();
    public bool BeingPulled { get; private set; }

    public Vector2 Position => transform.position._xz();

    public void OnWhipEnd(GameObject whipper)
    {
        BeingPulled = false;
    }

    public bool OnWhipStay(GameObject whipper)
    {
        var delta = whipper.transform.position._xz() - transform.position._xz();
        var force = (delta - Vector2.ClampMagnitude(delta, RANGE));
        Rigidbody.AddForce(force._x0y() * 3f, ForceMode.VelocityChange);
        return true;
    }


    IWhippable.WhipInteraction IWhippable.OnWhip(GameObject whipper)
    {
        BeingPulled = true;
        return IWhippable.WhipInteraction.Long;
    }
}
