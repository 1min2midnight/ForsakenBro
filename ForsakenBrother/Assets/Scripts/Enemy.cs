using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("enemy health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();

        }

    }
    void Die()
    {
        Debug.Log("Enemy Died!");
        GetComponent<Collider2D>().enabled = false;
        GetComponent<Renderer>().enabled = false;
        this.enabled = false;
    }
}
