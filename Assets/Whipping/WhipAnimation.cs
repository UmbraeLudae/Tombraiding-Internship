
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class WhipAnimation : MonoBehaviour
{
    PlayerWhip cached_PlayerWhip;
    PlayerWhip PlayerWhip => cached_PlayerWhip ??= GetComponent<PlayerWhip>();
    [SerializeField] private Transform WhipIKTarget;
    [SerializeField] private List<Rig> rigs = new();

    private Coroutine currentSwing;

    public void TriggerSwing(Vector2 targetLocation)
    {
        if (currentSwing != null) StopCoroutine(currentSwing);
        currentSwing = StartCoroutine(SwingRoutine(targetLocation));
    }

    private IEnumerator SwingRoutine(Vector2 targetLocation)
    {
        WhipIKTarget.position = targetLocation._x0y() + Vector3.up;
        StartIK();
        yield return new WaitForSeconds(.3f);
        StopIK();
    }

    public void StartIK() => rigs.ForEach(rig => rig.weight = 1);
    public void StopIK() => rigs.ForEach(rig => rig.weight = 0);

    private void FixedUpdate()
    {
        if (PlayerWhip.CurrentInteraction == null) return;
        WhipIKTarget.position = PlayerWhip.CurrentInteraction.Position._x0y() + Vector3.up;
        WhipIKTarget.rotation = Quaternion.Euler(WhipIKTarget.transform.position._x0z() - transform.position._x0z());
    }
}
