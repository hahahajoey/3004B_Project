using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagSlot : MonoBehaviour
{
    private Inventory inventory;
    public int index;
    private PlayerControlScript playerControlScript;
    

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        playerControlScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControlScript>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull_Bag[index] = false;
            playerControlScript.bagslots[index] = 0;
        }
    }
    public void DropItem_Bag()
    {
        foreach (Transform child in transform)
        {
            //child.GetComponent<Drop>().DropItemOnGround();
            GameObject.Destroy(child.gameObject);
        }
    }

    // Update is called once per frame

}
