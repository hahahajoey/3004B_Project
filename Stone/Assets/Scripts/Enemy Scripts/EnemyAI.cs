using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform sky;
    public Transform player;
    public float speed;
    private Rigidbody2D enemy;
    private Vector2 movement;
    private Vector2 movementBack;
    private float distance;
    private Vector3 startPoint;
    private int maxHealth = 100;
    public HealthBar healthBar;
    int currentHealth;
    public bool isDie;
    void Start()
    {
        isDie = false;
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(20);
        }
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
        transform.position = sky.position;
      
        

        //Die animation

        //Disable
    }
    void EnemyMovement(Vector2 d, Vector2 b)
    {
        distance = ((transform.position.y - player.position.y) * (transform.position.y - player.position.y)) + ((transform.position.x - player.position.x) * (transform.position.x - player.position.x));

        if (distance <= 30 && distance>4.5)
        {
            enemy.MovePosition((Vector2)transform.position + (d * speed * Time.deltaTime));
        }
        else if(distance <= 4.5)
        {
            enemy.MovePosition((Vector2)transform.position );
            player.GetComponent<PlayerControlScript>().TakeDamage(0.2f);
        }
        else if (transform.position.x - startPoint.x <0.1 && transform.position.y - startPoint.y < 0.1)
        {
            enemy.MovePosition((Vector2)transform.position);
        }
        else
        {
            enemy.MovePosition((Vector2)transform.position + (b * speed * Time.deltaTime));
        }
       
        
    }
}