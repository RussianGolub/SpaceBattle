using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    public event EventHandler OnShoot;
    public event EventHandler OnNitro;
    private InputPlayerActions inputActions;

    private void Awake() {
          inputActions = new InputPlayerActions();
          inputActions.Player.Enable();
          inputActions.Player.Shoot.performed += Player_OnShoot;
          inputActions.Player.Nitro.performed += Player_OnNitro;
    }

    private void Player_OnNitro(InputAction.CallbackContext context)
    {
        OnNitro?.Invoke(this, EventArgs.Empty);
    }

    private void Player_OnShoot(InputAction.CallbackContext context)
    {
        OnShoot?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMoveVector2Normolized()
   {
       Vector2 inputVector = inputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
   }
}
