using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public string[] name = new string[2];

    public string[] rep = new string[3];

    public string[] weight3d = new string[3];

    public SerializableDictionary<string, Vector3> SavedData;

    public GameData()
    {
        this.name[0] = "Name";
        this.name[1] = "Name";
        this.rep[0] = "monday exercise 1 rep 1";
        this.rep[1] = "monday exercise 1 rep 2";
        this.rep[2] = "monday exercise 1 rep 3";
        this.weight3d[0] = "monday exercise 1 rep 1";
        this.weight3d[1] = "monday exercise 1 rep 2";
        this.weight3d[2] = "monday exercise 1 rep 3";

        SavedData = new SerializableDictionary<string, Vector3>();
    }
}

