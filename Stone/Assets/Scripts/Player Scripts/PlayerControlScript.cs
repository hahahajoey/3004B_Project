using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{

    private Vector3 postion;


    public float speed = 1f;

    private bool death;
    private bool moveRight;
    private bool moveUp;
    private bool moveLeft;
    private bool moveDown;
    private bool allowmoveRight;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = false;
        allowmoveRight = true;
        postion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
         Move(); 
        
    }


 
 

    public void Move_Up()
    { transform.position += Vector3.up * speed * Time.deltaTime; }

   public void Move_Down()
    { transform.position += Vector3.down * speed * Time.deltaTime; }

    public void Move_Left()
    { transform.position += Vector3.left * speed * Time.deltaTime; }
    public void Move_Right()
    { transform.position += Vector3.right * speed * Time.deltaTime; }

    public void canmoveRight(bool movement)
    {
         moveRight = movement; 
       
    }
    public void canmoveLeft(bool movement)
    {
        moveLeft = movement;
    }
    public void canmoveUp(bool movement)
    {
        moveUp = movement;
    }
    public void canmoveDown(bool movement)
    {
        moveDown = movement;
    }
 

    void Move()
    {
        if (moveRight)
        {
            Move_Right(); 
            
        }
        else if (moveLeft)
        {
            Move_Left();
        }
        else if (moveUp)
        {
            Move_Up();
        }
        else if (moveDown)
        {
            Move_Down();
        }
    }

}
