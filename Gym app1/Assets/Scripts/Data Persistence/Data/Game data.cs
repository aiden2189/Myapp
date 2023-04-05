using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public string[] name = new string[2];

    public string[] rep = new string[3];

    public GameData()
    {
        this.name[0] = "Name";
        this.name[1] = "Name";
        this.rep[0] = "rep 1";
        this.rep[1] = "rep 2";
        this.rep[2] = "rep 3";
    }
}