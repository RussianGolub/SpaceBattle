using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1;
    private void Update() {
        HandleMovement();
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
}
