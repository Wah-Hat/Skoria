using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    // These are required in every script that needs to save or load data.
    void LoadData(GameData data);
    void SaveData(ref GameData data);
}