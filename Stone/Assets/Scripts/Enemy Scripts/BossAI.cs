using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed;
    private Rigidbody2D enemy;
    private Vector2 movement;
    private Vector2 movementBack;
    private float distance;
    private Vector3 startPoint;
    public HealthBar healthBar;
    int currentHealth;
    private int maxHealth = 300;
    public bool isDie;
    void Start()
    {
        enemy = this.GetComponent<Rigidbody2D>();
        startPoint = transform.position;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Vector3 directionFromStart = startPoint - transform.position;
        direction.Normalize();
        directionFromStart.Normalize();
        movement = direction;
        movementBack = directionFromStart;
    }

    private void FixedUpdate()
    {

        EnemyMovement(movement, movementBack);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        //Player hurt animation
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDie = true;
        Debug.Log("Enemy died!");
        Destroy(gameObject);
        //Die animation
        //Disable
    }
    void EnemyMovement(Vector2 d, Vector2 b)
    {
        distance = ((transform.position.y - player.position.y) * (transform.position.y - player.position.y)) + ((transform.position.x - player.position.x) * (transform.position.x - player.position.x));
            enemy.MovePosition((Vector2)transform.position + (d * speed * Time.deltaTime));
        if (distance <= 6)
        {
           enemy.MovePosition((Vector2)transform.position);
           player.GetComponent<PlayerControlScript>().TakeDamage(0.5f);
        }
    }
}