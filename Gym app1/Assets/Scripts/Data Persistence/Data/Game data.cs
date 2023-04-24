using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public string[] name = new string[2];

    public SerializableDictionary<string, string> SavedData;

    public GameData()
    {
        SavedData = new SerializableDictionary<string, string>();
    }
}

