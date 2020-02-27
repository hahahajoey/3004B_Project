using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Item : MonoBehaviour
{
    
    private Transform player;
    private HealthBar helthbar;

    // Update is called once per frame

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Use()
    {


        player.GetComponent<PlayerControlScript>().TakeDamage(-20);
        Destroy(gameObject);

    }
    
}
