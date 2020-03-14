using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInfo : MonoBehaviour
{
    private int maxHealth = 200;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(15);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //Player hurt animation

        if (currentHealth <= 0)
        {
            Die();
        }
    }



    void Die()
    {
        Debug.Log("You won!");
        Destroy(gameObject);
        //Die animation

        //Disable
    }
}
