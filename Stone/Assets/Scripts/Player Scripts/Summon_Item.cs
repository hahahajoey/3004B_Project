using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon_Item : MonoBehaviour
{

    private Transform player;
    
    private Inventory inventory;
    public GameObject item_slot;
    private PlayerControlScript playerControlScript;
    public int item_ID;
    
    public GameObject helper1;



    // Update is called once per frame

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
       

        playerControlScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>();
    }
    public void Use()
    {
        Instantiate(helper1, player.position, Quaternion.identity);
        //helper.transform.position = player.position;
        Destroy(gameObject);



    }
    public void PickFromBag()
    {

        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                playerControlScript.bagslots[i] = 0;
                playerControlScript.quickslots[i] = 2;
                //switch (item_ID)
                //{
                //    case 1:
                //        playerControlScript.quickslots[i] = 1;

                //        break;
                // }

                Instantiate(item_slot, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }

        }



    }

}
