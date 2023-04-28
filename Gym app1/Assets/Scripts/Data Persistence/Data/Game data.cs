using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public SerializableDictionary<string, string> SavedData;

    public GameData()
    {
        SavedData = new SerializableDictionary<string, string>();
    }
}

