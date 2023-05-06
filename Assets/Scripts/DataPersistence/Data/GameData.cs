using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public bool death;

    // Whenever a new game is made whatever is in this constructor are the default values.
    public GameData()
    {
        this.death = false;
    }
}