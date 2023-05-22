using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeID : MonoBehaviour, IDataPersistence
{
    public string ID;
    public string day;
    public string number;

    public void Monday()
    {
        day = "Monday";
    }
    public void Tuesday()
    {
        day = "Tuesday";
    }
    public void Wednesday()
    {
        day = "Wednesday";
    }
    public void Thursday()
    {
        day = "Thrusday";
    }
    public void Friday()
    {
        day = "Friday";
    }
    public void Saturday()
    {
        day = "Saturday";
    }
    public void Sunday()
    {
        day = "Sunday";
    }

    public void First()
    {
        number = "First";
    }
    public void Second()
    {
        number = "Second";
    }
    public void Third()
    {
        number = "Third";
    }
    public void Forth()
    {
        number = "Forth";
    }
    public void Fifth()
    {
        number = "Fifth";
    }
    public void Sixth()
    {
        number = "Sixth";
    }
    public void Seventh()
    {
        number = "Seventh";
    }
    public void Eighth()
    {
        number = "Eighth";
    }
    public void Ninth()
    {
        number = "Ninths";
    }

    public void Update()
    {
        ID = (day + " + " + number + " + ");
    }

    public void LoadData(GameData data)
    {

    }
    public void SaveData(GameData data)
    {
        if (data.SavedData.ContainsKey("password"))
        {
            data.SavedData.Remove("password");
        }
        data.SavedData.Add("password", ID);
    }
}
