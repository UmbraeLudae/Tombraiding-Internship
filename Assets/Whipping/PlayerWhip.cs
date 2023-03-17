using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerWhip : MonoBehaviour
{
    public Vector2 WhipDirection { get; set; }
    public float WhipLength;
    private bool m_whippingBuffer;
    private bool m_whippingInput;
    public bool Whipping { get => m_whippingBuffer; set => m_whippingBuffer |= (m_whippingInput = value); }

    private float whipCooldown = .5f;
    private float lastWhipTime;

    private IWhippable m_currentInteraction;
    public IWhippable CurrentInteraction => m_currentInteraction;

    private WhipAnimation cached_WhipAnimation;
    private WhipAnimation WhipAnimation => cached_WhipAnimation ??= GetComponentInChildren<WhipAnimation>();



    void FixedUpdate()
    {
        m_whippingBuffer = m_whippingInput;
        if (CurrentInteraction != null)
        {
            if (Whipping && CurrentInteraction.OnWhipStay(gameObject)) return;
            WhipStop();
        }

        if (!Whipping) return;

        if (lastWhipTime + whipCooldown > Time.time) return;
        lastWhipTime = Time.time;
        Whip();
    }

    public void WhipStop()
    {
        CurrentInteraction?.OnWhipEnd(gameObject);
        m_currentInteraction = null;
        WhipAnimation.StopIK();
        lastWhipTime = Time.time;
    }

    public void Whip()
    {

        var a1 = transform.position;
        var a2 = transform.position + WhipDirection._x0y().normalized * WhipLength;
        Debug.DrawLine(a1, a2, Color.red, 1f);
        var hitObjects = Physics.OverlapCapsule(a1, a2, .3f);
        var whippees = hitObjects.Select(obj => obj.GetComponentInParent<IWhippable>())
                                                   .Where(whippable => whippable != null)
                                                   .OrderBy(whippee => (transform.position._xz() - whippee.Position).magnitude);

        var whipQueue = new Queue<IWhippable>(whippees);
        while (whipQueue.Count > 0)
        {
            var whippee = whipQueue.Dequeue();
            var interactionType = whippee.OnWhip(gameObject);
            switch (interactionType)
            {
                case IWhippable.WhipInteraction.Pass:
                    continue;
                case IWhippable.WhipInteraction.Long:
                    m_currentInteraction = whippee;
                    WhipAnimation.StartIK();
                    return;
                case IWhippable.WhipInteraction.Consume:
                    WhipAnimation.TriggerSwing(whippee.Position);
                    return;
            }
        }
        WhipAnimation.TriggerSwing(a2._xz());
    }
}
