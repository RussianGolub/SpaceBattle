using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1;
    private float timer = 1;
    private void Update()
    {
        HandleMovement();
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            HandleShoot();
        }
    }
    public void DestroyTarget()
    {
        ScoreManager.Instance.AddScore(1);
        Destroy(gameObject);
    }

    private void HandleMovement()
    {
        transform.position -= new Vector3(0, Time.deltaTime * fallSpeed, 0);
    }

    private void HandleShoot()
    {
        timer = 1 + Random.Range(0f, 0.5f);

        GetComponent<Shooter>().Shoot(-transform.up, gameObject.tag);
    }
}
