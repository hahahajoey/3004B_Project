using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int slotNum;
    
    public Transform player;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.isFull[slotNum] = false;
        }
    }
    public void DropItem()
    {
        
        foreach (Transform child in transform)
        {
            Vector2 itemPostion = new Vector2(player.position.x, player.position.y + 2f);
            Instantiate(child.gameObject, itemPostion, Quaternion.identity);
            
            GameObject.Destroy(child.gameObject);
            


        }
    }

  
}
