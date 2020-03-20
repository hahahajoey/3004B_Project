using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public float maxHealth = 200;

    public float currentHealth;

    public Vector3 position;

    public float speed = 1f;

    public Rigidbody2D rb;

    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;

    public HealthBar healthBar;

    public int level;

    public int[] quickslots;

    public int[] bagslots;

    private bool death;

    Vector2 movement;

    private bool isMoving;

    public GameObject pauseUI;
    private Inventory inventory;
    public GameObject summon;
    public GameObject apple;
    public GameObject summonInBag;
    public GameObject appleInBag;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        quickslots = new int[4];
        bagslots = new int[33];
        Load_State();
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        if(currentHealth <= 0)
        {
            Debug.Log("Game over");
            pauseUI.SetActive(true);
            //Destroy(gameObject);
           
        }
        if (! isMoving)
        {
            rb.MovePosition((Vector2)transform.position);
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

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void stop()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
        animator.SetFloat("Speed", 0);
        isMoving = false;

    }
    public void stop1()
    {
        rb.velocity = new Vector2( rb.velocity.x, 0f);
        animator.SetFloat("Speed", 0);
        isMoving = false;
    }



    //move call
    public void Move_Up() 
    { rb.velocity = new Vector2(rb.velocity.x ,+speed );
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Speed", 1);
        isMoving = true;
        //animator.SetFloat("Horizontal", 1);
        //animator.SetFloat("Vertical", 0);
        //animator.SetFloat("Speed", 1);


    }

    public void Move_Down()
    { rb.velocity = new Vector2(rb.velocity.x, -speed);
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Speed", 1);
        isMoving = true;
    }

    public void Move_Left()
    { rb.velocity = new Vector2(-speed, rb.velocity.y);
        animator.SetFloat("Horizontal", -1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed", 1);
        isMoving = true;

    }
    public void Move_Right()
    { rb.velocity = new Vector2(speed, rb.velocity.y);
        animator.SetFloat("Horizontal", 1);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed", 1);
        isMoving = true;

    }

    public void Save_State()
    {
        position = transform.position;
        Save_and_load.Save(this);
    }

    //attack funtion
    public void Attack()
    {
        //Play an attack animation
        animator.SetTrigger("Attack");
        //Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); 
        //Damage enemies
        foreach(Collider2D enemy in hitEnemies)
        {
            //Debug.Log("We hit the enemy");
            enemy.GetComponent<EnemyAI>().TakeDamage(25);
        }
    }

    public void Shoot()
    {
        animator.SetTrigger("Shoot");
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    void Loadinventory(int[] quickslots, int[] bagslots)
    {
        for(int i=0;i< quickslots.Length; i++)
        {
            if (quickslots[i] == 1)
            {
                inventory.isFull[i] = true;
                Instantiate(apple, inventory.slots[i].transform, false);
            }
            else if (quickslots[i] == 2)
            {
                inventory.isFull[i] = true;
                Instantiate(summon, inventory.slots[i].transform, false);

            }
        }
        for (int i = 0; i < bagslots.Length; i++)
        {
            if (bagslots[i] == 1)
            {
                inventory.isFull_Bag[i] = true;
                Instantiate(appleInBag, inventory.bagslot[i].transform, false);
            }
            else if (bagslots[i] == 2)
            {
                inventory.isFull_Bag[i] = true;
                Instantiate(summonInBag, inventory.bagslot[i].transform, false);

            }
        }
    }

    public void Load_State()
    {
        PlayerState temp = Save_and_load.Loadinfo();
        currentHealth = temp.hp;
        position.x = temp.position[0];
        position.y = temp.position[1];
        transform.position = position;
        level = temp.level;
        Loadinventory(temp.quickslots, temp.bagslots);
        quickslots = temp.quickslots;
        bagslots = temp.bagslots;
    }
}
