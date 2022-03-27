using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f; //it will take player to shoot 5 time to kill the enemy

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health -= amount)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
