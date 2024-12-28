using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputPlayer inputPlayer;

private void Awake() {
    inputPlayer.OnShoot += inputPlayer_OnShoot;
    inputPlayer.OnNitro += inputPlayer_OnNitro;
}

    private void inputPlayer_OnNitro(object sender, EventArgs e)
    {
        GetComponent<Rigidbody2D>().AddForce(inputPlayer.GetMoveVector2Normolized()*200,ForceMode2D.Force);
    }

    private void Update() 
{
    HandleMovement();
}   

private void inputPlayer_OnShoot(object sender, EventArgs e)
{
    gameObject.GetComponent<Shooter>().Shoot(transform.up,gameObject.tag);
}

private void HandleMovement()
{
    Vector2 inputVector = inputPlayer.GetMoveVector2Normolized();
    Vector3 moveDirection = new Vector3(inputVector.x, inputVector.y, 0);
    GetComponent<Rigidbody2D>().AddForce(moveDirection,ForceMode2D.Force);
}


private void OnTriggerEnter2D(Collider2D other) 
{
    if(other.gameObject.CompareTag("Target"))
    {
        other.gameObject.GetComponent<Target>().DestroyTarget();
    }
}
}


