using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame

    public void DropItemOnGround()
    {
        Vector2 dropPostion = new Vector2(player.position.x, player.position.y + 1);
        Instantiate(item, dropPostion, Quaternion.identity);
    }
    
}
