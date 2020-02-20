using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{

    private Vector3 postion;

    public float speed = 1f;

    public Rigidbody2D rb;

    public Animator animator;

    private bool death;
    private bool CanMoveRight;
    private bool CanMoveLeft;
    private bool CanMoveUp;
    private bool CanMoveDown;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        postion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void Move_Up() 
    { transform.position += Vector3.up * speed * Time.deltaTime;}

    void Move_Down()
    { transform.position += Vector3.down * speed *Time.deltaTime;}

    void Move_Left()
    { transform.position += Vector3.left * speed * Time.deltaTime;}
    void Move_Right()
    { transform.position += Vector3.right * speed * Time.deltaTime;}
    public void Allow_Move_Right(bool m)
    {
        CanMoveRight = m;
    }
    public void Allow_Move_Left(bool m)
    {
        CanMoveLeft = m;
    }
    public void Allow_Move_Up(bool m)
    {
        CanMoveUp = m;
    }
    public void Allow_Move_Down(bool m)
    {
        CanMoveDown = m;
    }

    void Move()
    {
        if (CanMoveRight)
        {
            Move_Right();
        }
        if (CanMoveLeft)
        {
            Move_Left();

        }
        if (CanMoveUp)
        {
            Move_Up();
        }
        if (CanMoveDown)
        {
            Move_Down();
        }
    }

}
