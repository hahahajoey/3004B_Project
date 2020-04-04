using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item_slot;
    public int item_ID;
    public GameObject item_bag;
    public PlayerControlScript player;
    private bool slotFull;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //for(int i=0; i < inventory.slots.Length; i++)
            //{
              //  if(inventory.isFull[i] == false)
               // {
                //    inventory.isFull[i] = true;
                //    switch (item_ID)
                 //   {
                 //       case 1:
                  //          player.quickslots[i] = 1;
                 //           break;
                  //  }
                  //  Instantiate(item_slot, inventory.slots[i].transform, false);
                   // Destroy(gameObject);
               //     break;
              //  }
            //    if(i == inventory.slots.Length - 1)
             //   {
             //       slotFull = true;
             //   }
          //  }
         //   if (slotFull)
          //  {
                for (int i = 0; i < inventory.bagslot.Length; i++)
                {
                    if (inventory.isFull_Bag[i] == false)
                    {
                        inventory.isFull_Bag[i] = true;
                    switch (item_ID)
                         {
                             case 1:
                                player.bagslots[i] = 1;
                            break;
                            case 2:
                                player.bagslots[i] = 2;
                            break;
                        }
                    
                    
                    Instantiate(item_bag, inventory.bagslot[i].transform, false);

                        Destroy(gameObject);
                        break;
                    }
                }
        }
    }
}
