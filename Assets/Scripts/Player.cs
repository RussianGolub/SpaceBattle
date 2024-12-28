using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputPlayer inputPlayer;

private void Update() {
    HandleMovement();
}

private void HandleMovement()
{
    float moveSpeed = 5f;
    Vector2 inputVector = inputPlayer.GetMoveVector2Normolized();
    Vector3 moveDir = new Vector3(inputVector.x, 0, 0);
    GetComponent<Rigidbody2D>().AddForce(moveDir,ForceMode2D.Force);
}

private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("Target"))
    {
        other.gameObject.GetComponent<Target>().DestroyTarget();
    }
}
}


