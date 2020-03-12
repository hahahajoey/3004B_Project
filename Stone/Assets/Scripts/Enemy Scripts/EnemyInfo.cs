using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //Player hurt animation

        if (currentHealth == 0){
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");
        //Die animation

        //Disable
    }
}
