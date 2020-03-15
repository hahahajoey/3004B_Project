using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperAI : MonoBehaviour
{
    // Start is called before the first frame update
 
    private Transform enemy1;
    private Transform enemy2;
    private Transform enemy3;
    private Transform enemy4;

    private Transform player;
    private Rigidbody2D helper;
    private float distance1;
    private float distance2;
    private float distance3;
    private float distance4;
    private float timeCount = 0.0f;
    private bool check1;
    void Start()
    {

        check1 = true;
        helper = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemy1 = GameObject.FindGameObjectWithTag("enemy1").transform;
        enemy2 = GameObject.FindGameObjectWithTag("enemy2").transform;
        enemy3 = GameObject.FindGameObjectWithTag("enemy3").transform;
        enemy4 = GameObject.FindGameObjectWithTag("enemy4").transform;
     







    }

    // Update is called once per frame
    void Update()
    {
        if (check1)
        {

            distance1 = ((transform.position.y - enemy1.position.y) * (transform.position.y - enemy1.position.y)) + ((transform.position.x - enemy1.position.x) * (transform.position.x - enemy1.position.x));



            distance2 = ((transform.position.y - enemy2.position.y) * (transform.position.y - enemy2.position.y)) + ((transform.position.x - enemy2.position.x) * (transform.position.x - enemy2.position.x));


            distance3 = ((transform.position.y - enemy3.position.y) * (transform.position.y - enemy3.position.y)) + ((transform.position.x - enemy3.position.x) * (transform.position.x - enemy3.position.x));


            distance4 = ((transform.position.y - enemy4.position.y) * (transform.position.y - enemy4.position.y)) + ((transform.position.x - enemy4.position.x) * (transform.position.x - enemy4.position.x));


            if (Input.GetKeyDown(KeyCode.P))
            {
                transform.position = player.position;

            }
            timeCount += Time.deltaTime;
            if (timeCount >= 4f)
            {

                Destroy(gameObject);
            }


        }
    }

    private void FixedUpdate()
    {

        AttackEnemy();
    }
    void AttackEnemy()
    {


        

        // Debug.Log(transform.position);


        if (distance1 <= 6)
        {
           
            helper.MovePosition((Vector2)transform.position);
            enemy1.GetComponent<EnemyAI>().TakeDamage(1);

        }
        if (distance2 <= 6)
        {
            
            helper.MovePosition((Vector2)transform.position);
            enemy2.GetComponent<EnemyAI>().TakeDamage(1);
        }
        if (distance3 <= 6)
        {
           
            helper.MovePosition((Vector2)transform.position);
            enemy3.GetComponent<EnemyAI>().TakeDamage(1);
        }
        if (distance4 <= 6)
        {
            
            helper.MovePosition((Vector2)transform.position);
            enemy4.GetComponent<EnemyAI>().TakeDamage(1);
        }


    }
}