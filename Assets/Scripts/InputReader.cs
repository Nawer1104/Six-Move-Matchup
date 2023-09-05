using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputReader : MonoBehaviour
{
    SixMoveMatchup playerInput;

    InputAction selectAction;
    InputAction fireAction;

    public event EventHandler Fire;

    public Vector2 Selected => selectAction.ReadValue<Vector2>();

    private void Awake()
    {
        playerInput = new SixMoveMatchup();
    }

    private void OnEnable()
    {
        selectAction = playerInput.Player.Select;
        selectAction.Enable();

        fireAction = playerInput.Player.Fire;
        fireAction.Enable();

        fireAction.performed += FireAction_performed;
    }

    private void FireAction_performed(InputAction.CallbackContext obj)
    {
        Fire?.Invoke(this, EventArgs.Empty);
    }

    private void OnDisable()
    {
        selectAction.Disable();
        fireAction.Disable();

        fireAction.performed -= FireAction_performed;
    }
}
