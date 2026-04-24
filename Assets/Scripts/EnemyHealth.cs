using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    public void SubtractHealth(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
