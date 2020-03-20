using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerState
{
    public float hp;
    public float[] position;
    public int level;
    public int[] quickslots;
    public int[] bagslots;

    public PlayerState()
    {
        hp = 200;
        position = new float[2];
        position[0] = 17.73f;
        position[1] = 9.83f;
        level = 0;
        quickslots = new int[4];
        bagslots = new int[33];
    }

    public PlayerState(PlayerControlScript player)
    {
        position = new float[2];
        hp = player.currentHealth;
        level = player.level;
        position[0] = player.position.x;
        position[1] = player.position.y;
        quickslots = player.quickslots;
        bagslots = player.bagslots;
    }

    public PlayerState(PlayerControlScript player, float[] getposition, int leveladd)
    {
        position = new float[2];
        hp = player.currentHealth;
        Debug.Log(player.level + leveladd);
        level = player.level + leveladd;
        position[0] = getposition[0];
        position[1] = getposition[1];
        quickslots = player.quickslots;
        bagslots = player.bagslots;
    }
}
