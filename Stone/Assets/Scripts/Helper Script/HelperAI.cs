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
    private Transform enemy5;
    private Transform enemy6;
    private int level;

    private Transform player;
    private Rigidbody2D helper;
    private float distance1;
    private float distance2;
    private float distance3;
    private float distance4;
    private float distance5;
    private float distance6;
    private float timeCount = 0.0f;
    
    void Start()
    {
        level = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>().level;
        
        helper = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (level == 0 || level == 1)
        {
            enemy1 = GameObject.FindGameObjectWithTag("enemy1").transform;
            enemy2 = GameObject.FindGameObjectWithTag("enemy2").transform;
            enemy3 = GameObject.FindGameObjectWithTag("enemy3").transform;
            enemy4 = GameObject.FindGameObjectWithTag("enemy4").transform;

        }
        else if (level == 2)
        {
            enemy1 = GameObject.FindGameObjectWithTag("enemy1").transform;
            enemy2 = GameObject.FindGameObjectWithTag("enemy2").transform;
            enemy3 = GameObject.FindGameObjectWithTag("enemy3").transform;
            enemy4 = GameObject.FindGameObjectWithTag("enemy4").transform;
            enemy5 = GameObject.FindGameObjectWithTag("enemy5").transform;
            enemy6 = GameObject.FindGameObjectWithTag("enemy6").transform;
            
        }
        else if (level == 3)
        {
            enemy1 = GameObject.FindGameObjectWithTag("enemy1").transform;
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 0 || level == 1)
        {

            distance1 = ((transform.position.y - enemy1.position.y) * (transform.position.y - enemy1.position.y)) + ((transform.position.x - enemy1.position.x) * (transform.position.x - enemy1.position.x));



            distance2 = ((transform.position.y - enemy2.position.y) * (transform.position.y - enemy2.position.y)) + ((transform.position.x - enemy2.position.x) * (transform.position.x - enemy2.position.x));


            distance3 = ((transform.position.y - enemy3.position.y) * (transform.position.y - enemy3.position.y)) + ((transform.position.x - enemy3.position.x) * (transform.position.x - enemy3.position.x));


            distance4 = ((transform.position.y - enemy4.position.y) * (transform.position.y - enemy4.position.y)) + ((transform.position.x - enemy4.position.x) * (transform.position.x - enemy4.position.x));


            
            timeCount += Time.deltaTime;
            if (timeCount >= 4f)
            {

                Destroy(gameObject);
            }


        }
      
        else if (level == 2)
        {
            distance1 = ((transform.position.y - enemy1.position.y) * (transform.position.y - enemy1.position.y)) + ((transform.position.x - enemy1.position.x) * (transform.position.x - enemy1.position.x));
            distance2 = ((transform.position.y - enemy2.position.y) * (transform.position.y - enemy2.position.y)) + ((transform.position.x - enemy2.position.x) * (transform.position.x - enemy2.position.x));
            distance3 = ((transform.position.y - enemy3.position.y) * (transform.position.y - enemy3.position.y)) + ((transform.position.x - enemy3.position.x) * (transform.position.x - enemy3.position.x));
            distance4 = ((transform.position.y - enemy4.position.y) * (transform.position.y - enemy4.position.y)) + ((transform.position.x - enemy4.position.x) * (transform.position.x - enemy4.position.x));
            distance5 = ((transform.position.y - enemy5.position.y) * (transform.position.y - enemy5.position.y)) + ((transform.position.x - enemy5.position.x) * (transform.position.x - enemy5.position.x));
            distance6 = ((transform.position.y - enemy6.position.y) * (transform.position.y - enemy6.position.y)) + ((transform.position.x - enemy6.position.x) * (transform.position.x - enemy6.position.x));



            timeCount += Time.deltaTime;
            if (timeCount >= 4f)
            {

                Destroy(gameObject);
            }
        }
        else if(level == 3)
        {
            distance1 = ((transform.position.y - enemy1.position.y) * (transform.position.y - enemy1.position.y)) + ((transform.position.x - enemy1.position.x) * (transform.position.x - enemy1.position.x));

        }
    }

    private void FixedUpdate()
    {

        AttackEnemy();
    }
    void AttackEnemy()
    {




        // Debug.Log(transform.position);

        if (level == 0 || level == 1)
        {
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
     
        else if (level == 2)
        {
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
            if (distance5 <= 6)
            {

                helper.MovePosition((Vector2)transform.position);
                enemy5.GetComponent<EnemyAI>().TakeDamage(1);
            }
            if (distance6 <= 6)
            {

                helper.MovePosition((Vector2)transform.position);
                enemy6.GetComponent<EnemyAI>().TakeDamage(1);
            }
        }

        else if (level == 3)
        {
            if (distance1 <= 6)
            {

                helper.MovePosition((Vector2)transform.position);
                enemy1.GetComponent<BossAI>().TakeDamage(1);

            }
        }


    }
}