using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    private int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(20);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //Player hurt animation

        if (currentHealth <= 0){
            Die();
        }
    }

    

    void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);

        //Die animation

        //Disable
    }
}
