using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int healthAmount;
    [SerializeField] private int healthAmountMAX;

    private void Awake() {
        healthAmount = healthAmountMAX;
    }

    public void Damage(int damage)
    {
        healthAmount-=damage;
        Mathf.Clamp(healthAmount, 0, healthAmountMAX);
        if(healthAmount == 0)
        {
            Destroy(gameObject);
        }
    }
}
