using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    private InputPlayerActions inputActions;

    private void Awake() {
          inputActions = new InputPlayerActions();
          inputActions.Player.Enable();
    }

   public Vector2 GetMoveVector2Normolized()
   {
       Vector2 inputVector = inputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
   }
}
