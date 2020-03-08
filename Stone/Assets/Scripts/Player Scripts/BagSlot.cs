using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagSlot : MonoBehaviour
{
    private Inventory inventory;
    public int index;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull_Bag[index] = false;
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
