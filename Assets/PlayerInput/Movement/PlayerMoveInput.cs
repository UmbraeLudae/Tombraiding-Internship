
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMove), typeof(PlayerRoll))]
public class PlayerMoveInput : MonoBehaviour, PlayerMoveActions.IMovementActions
{

    private PlayerMove cached_PlayerMove;
    private PlayerMove PlayerMove => cached_PlayerMove ??= GetComponent<PlayerMove>();

    private PlayerRoll cached_PlayerRoll;
    private PlayerRoll PlayerRoll => cached_PlayerRoll ??= GetComponent<PlayerRoll>();

    private PlayerMoveActions actions;

    void Start()
    {
        actions = new();
        actions.Movement.SetCallbacks(this);
        actions.Enable();
    }

    void OnEnable() => actions?.Enable();
    void OnDisable() => actions?.Disable();

    public void OnMove(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<Vector2>();
        PlayerMove.InputDirection = input;
        PlayerRoll.RollDirection = input;
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        PlayerRoll.Rolling = context.ReadValueAsButton();
    }
}
