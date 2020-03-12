using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerState
{
    public int hp;
    public float [] position;
    public Inventory inventory;
    public int level;

    public PlayerState(PlayerControlScript player)
    {
        position = new float[2];
        hp = player.currentHealth;
        level = player.level;
        position[0] = player.position.x;
        position[1] = player.position.y;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
}
