using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Item : MonoBehaviour
{
    
    private Transform player;
    private HealthBar helthbar;
    private Inventory inventory;
    public GameObject item_slot;

    // Update is called once per frame

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public void Use()
    {


        player.GetComponent<PlayerControlScript>().TakeDamage(-20);
        Destroy(gameObject);

    }
    public void PickFromBag()
    {

        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                Instantiate(item_slot, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
            
        }

        

    }

}
