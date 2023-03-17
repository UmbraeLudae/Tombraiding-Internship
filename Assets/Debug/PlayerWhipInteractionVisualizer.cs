using UnityEngine;

public class PlayerWhipInteractionVisualizer : MonoBehaviour
{
    [SerializeField] private LineRenderer lr;
    private PlayerWhip cached_PlayerWhip;
    private PlayerWhip PlayerWhip => cached_PlayerWhip ??= GetComponent<PlayerWhip>();

    private Transform WhipIKTarget;
    void Update()
    {
        var currentInteraction = PlayerWhip.CurrentInteraction;
        if (currentInteraction == null) return;
        WhipIKTarget.position = currentInteraction.Position._x0y() + Vector3.up;
    }
}
