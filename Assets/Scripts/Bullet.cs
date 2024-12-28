using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int damage;
    private float speed;
    private string ownerTag;
    private Vector3 moveDirection;

    public void Initialize(Vector3 moveDirection, int damage, float speed,string tag)
    {
        this.moveDirection = moveDirection;
        this.damage = damage;
        this.speed = speed;
        ownerTag = tag;
    }
    private void Update() {
        transform.position += moveDirection*Time.deltaTime*speed;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == ownerTag)
        {
            return;
        }
        if (other.gameObject.TryGetComponent<HealthSystem>(out HealthSystem healthSystem))
        {
            healthSystem.Damage(damage);
            Destroy(gameObject);
        }
    }
}
