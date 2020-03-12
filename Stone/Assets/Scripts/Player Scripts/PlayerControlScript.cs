using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public Vector3 position;

    public float speed = 1f;

    public Rigidbody2D rb;

    public Animator animator;

    public HealthBar healthBar;

    public int level;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    private bool death;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void stop()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
        animator.SetFloat("Speed", 0);

    }
    public void stop1()
    {
        rb.velocity = new Vector2( rb.velocity.x, 0f);
        animator.SetFloat("Speed", 0);
    }



    //move call
    public void Move_Up() 
    { rb.velocity = new Vector2(rb.velocity.x ,+speed );
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Speed", 1);
        //animator.SetFloat("Horizontal", 1);
        //animator.SetFloat("Vertical", 0);
        //animator.SetFloat("Speed", 1);


    }

    public void Move_Down()
    { rb.velocity = new Vector2(rb.velocity.x, -speed);
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Speed", 1);
    }

    public void Move_Left()
    { rb.velocity = new Vector2(-speed, rb.velocity.y);
        animator.SetFloat("Horizontal", -1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed", 1);

    }
    public void Move_Right()
    { rb.velocity = new Vector2(speed, rb.velocity.y);
        animator.SetFloat("Horizontal", 1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed", 1);

    }

    public void Save_State()
    {Save_and_load.Save(this);}

    //attack funtion
    void Attack()
    {
        //Play an attack animation
        animator.SetTrigger("Attack");
        //Detect enemies in the range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //Damage
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit an enemy");

        }
    }
    void Shoot()
    {
        //Play an attack animation
        animator.SetTrigger("Shoot");
        //Detect enemies in the range of attack
        //Damage
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }




}
