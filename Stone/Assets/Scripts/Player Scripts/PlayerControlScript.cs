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

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        { Move_Right(); }
        else if (Input.GetKey(KeyCode.LeftArrow))
        { Move_Left(); }
        else if (Input.GetKey(KeyCode.UpArrow))
        { Move_Up(); }
        else if (Input.GetKey(KeyCode.DownArrow))
        { Move_Down(); }
    }

}
