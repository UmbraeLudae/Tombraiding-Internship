using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerWhip))]
public class PlayerWhipInput : MonoBehaviour, WhipActions.IWhippingActions
{
    private WhipActions actions;
    private PlayerWhip cached_PlayerWhip;
    private PlayerWhip PlayerWhip => cached_PlayerWhip ??= GetComponent<PlayerWhip>();

    void Start()
    {
        actions = new();
        actions.Whipping.SetCallbacks(this);
        actions.Enable();
    }

    void OnEnable() => actions?.Enable();
    void OnDisable() => actions?.Disable();

    public void OnWhip(InputAction.CallbackContext context)
    {
        PlayerWhip.Whipping = context.ReadValueAsButton();
    }    

    public void OnWhipTarget(InputAction.CallbackContext context)
    {
        var screenPos = context.ReadValue<Vector2>();
        var ray = Camera.main.ScreenPointToRay(screenPos);
        var t = -ray.origin.y / ray.direction.y;
        var worldPos = ray.GetPoint(t);
        PlayerWhip.WhipDirection = (worldPos - PlayerWhip.transform.position)._xz();
    }
}
