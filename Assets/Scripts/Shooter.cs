using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float speed;
    private Transform bulletPrefab;
    private void Awake() {
        bulletPrefab = Resources.Load<Transform>("Bullet");
    }
    public void Shoot(Vector3 moveDirection, string tag)
    {
        Transform bulletTransform = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletTransform.GetComponent<Bullet>().Initialize(moveDirection,damage,speed,tag);
    }
}
