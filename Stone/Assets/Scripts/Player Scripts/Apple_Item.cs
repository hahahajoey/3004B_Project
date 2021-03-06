﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Item : MonoBehaviour
{
    
    private Transform player;
    private HealthBar helthbar;
    private Inventory inventory;
    public GameObject item_slot;
    private PlayerControlScript playerControlScript;
    public int item_ID;


    // Update is called once per frame

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    playerControlScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>();
    }
    public void Use()
    {

        if(player.GetComponent<PlayerControlScript>().currentHealth <= player.GetComponent<PlayerControlScript>().maxHealth - 20)
        {
            player.GetComponent<PlayerControlScript>().TakeDamage(-20);
            //playerControlScript.quickslots[i] = 0;
            Destroy(gameObject);
        }
        else if(player.GetComponent<PlayerControlScript>().currentHealth == player.GetComponent<PlayerControlScript>().maxHealth)
        {
            return;
        }
        else
        {
            player.GetComponent<PlayerControlScript>().TakeDamage(player.GetComponent<PlayerControlScript>().currentHealth- player.GetComponent<PlayerControlScript>().maxHealth);
            Destroy(gameObject);
        }
      
       

    }
    public void PickFromBag()
    {

        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                switch (item_ID)
                 {
                     case 1:
                        playerControlScript.quickslots[i] = 1;
                        
                         break;
                }
                playerControlScript.bagslots[i] = 0;


              Instantiate(item_slot, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
            
        }

        

    }

}
