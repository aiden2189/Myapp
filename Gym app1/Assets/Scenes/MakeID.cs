using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakeID : MonoBehaviour, IDataPersistence
{
    public string ID;
    public string day;
    public string number;

    public GameObject canvas;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    public void Awake()
    {
        canvas = GameObject.Find("/Canvas/Buttons/Button (1)");

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Monday") 
        {
            button1 = canvas.GetComponent<Button>();
            button1.onClick.AddListener(First);
        }
    }

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
