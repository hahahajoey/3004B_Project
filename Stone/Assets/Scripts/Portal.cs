using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public PlayerControlScript player;

    public GameObject Teleport;
    public GameObject Player;

   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Debug.Log("¿¿¿");
        }
    }
}
