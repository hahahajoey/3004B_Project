using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{

    private Vector3 postion;


    public float speed = 1f;
    public Rigidbody2D mybody;
    private bool death;
    private bool moveRight = false;
    private bool moveUp = false;
    private bool moveLeft = false;
    private bool moveDown = false;
    private bool allowmoveRight;
    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Update()
    {
        

        Move();

        Stop();
        
    }


   
    public void MoveLeft()
    {

        mybody.velocity = new Vector2(-speed, mybody.velocity.y);
        

    }
  
    public void MoveRight()
    {
        mybody.velocity = new Vector2(speed, mybody.velocity.y);

    }
    public void MoveDown()
    {
        mybody.velocity = new Vector2(mybody.velocity.x, -speed);

    }
    public void MoveUp()
    {
        mybody.velocity = new Vector2(mybody.velocity.x,speed);


    }





    public void canmoveRight(bool m)
    {
        moveRight = m;
       
        animator.SetFloat("Horizontal", -1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("speed", 1);
    }
    public void canmoveLeft(bool m)
    {
        moveLeft = m;

        animator.SetFloat("Horizontal", 1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("speed", 1);



    }
    public void canmoveUp(bool m)
    {
        moveUp = m;
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("speed", 1);
    }
    public void canmoveDown(bool m)
    {
        moveDown = m;
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("speed", 1);
    }


    void Move()
    {
       // movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");

      

        if (moveRight)
        {
            MoveRight();
            

        }
       
        else if (moveDown)
        {
            MoveDown();

        }
        else if (moveUp)
        {
            MoveUp();

        }
        else if (moveLeft)
        {
            MoveLeft();

        }
       
        //movement.sqrMagnitude




    }
    void Stop()
    {
        if ((!moveRight)  & (!moveLeft))
        {
            mybody.velocity = new Vector2(0f, mybody.velocity.y);
            
        }
        if ((!moveUp) & (!moveDown))
        {
            mybody.velocity = new Vector2(mybody.velocity.x,0f);
            
        }
        if ((!moveUp) & (!moveDown) & (!moveRight) & (!moveLeft))
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("speed", 0);
        }
    }



}
