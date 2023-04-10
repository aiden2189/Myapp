using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public string[] name = new string[2];

    public string[,] rep = new string[3,3];
    public string[,] weight = new string[3,3];

    public GameData()
    {
        this.name[0] = "Name";
        this.name[1] = "Name";
        this.rep[0,0] = "rep 1";
        this.rep[1,0] = "rep 2";
        this.rep[2,0] = "rep 3";
        this.weight[0,0] = "weight 1";
        this.weight[1,0] = "weight 2";
        this.weight[2,0] = "weight 3";
    }
}