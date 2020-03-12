using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed;
    private Rigidbody2D enemy;
    private Vector2 movement;
    private Vector2 movementBack;
    private float distance;
    private Vector3 startPoint;
    void Start()
    {
        enemy = this.GetComponent<Rigidbody2D>();
        startPoint = transform.position;
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
    void EnemyMovement(Vector2 d, Vector2 b)
    {
        distance = ((transform.position.y - player.position.y) * (transform.position.y - player.position.y)) + ((transform.position.x - player.position.x) * (transform.position.x - player.position.x));
        
        
       
       // Debug.Log(transform.position);

        if (distance <= 30 && distance>4)
        {
            enemy.MovePosition((Vector2)transform.position + (d * speed * Time.deltaTime));
        }
        else if(distance <= 4)
        {
            //enemy.MovePosition((Vector2)transform.position );
            player.GetComponent<PlayerControlScript>().TakeDamage(1);
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