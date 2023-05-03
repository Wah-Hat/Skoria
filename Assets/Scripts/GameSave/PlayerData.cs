using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    [Tooltip("Stores current level of player.")]
    public int level;

    [Tooltip("Stores current health of player.")]
    public int health;

    [Tooltip("Stores current x (0) and y(1) cords of player")]
    public float[] position;

    public PlayerData(Player player)
    {
        level = player.level;
        health = player.health;

        // Add position of player on map to this array.
        position = new float[2];
    }
}
