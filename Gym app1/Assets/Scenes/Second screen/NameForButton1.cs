using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameForButton1 : MonoBehaviour, IDataPersistence
{
    public GameObject[] text = new GameObject[12];

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[12];

    public string[] Name = new string[12];

    public string day;

    public string[] id = new string[12];

    void Awake()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[4] = text[4].GetComponent<TextMeshProUGUI>();
        actualtext[5] = text[5].GetComponent<TextMeshProUGUI>();
        actualtext[6] = text[6].GetComponent<TextMeshProUGUI>();
        actualtext[7] = text[7].GetComponent<TextMeshProUGUI>();
        actualtext[8] = text[8].GetComponent<TextMeshProUGUI>();
        actualtext[9] = text[9].GetComponent<TextMeshProUGUI>();
        actualtext[10] = text[10].GetComponent<TextMeshProUGUI>();
        actualtext[11] = text[11].GetComponent<TextMeshProUGUI>();
    }
    
    void Start()
    {
        id[0] = (day + " + First = name");
        id[1] = (day + " + Second = name");
        id[2] = (day + " + Third = name");
        id[3] = (day + " + Forth = name");
        id[4] = (day + " + Fifth = name");
        id[5] = (day + " + Sixth = name");
        id[6] = (day + " + Seventh = name");
        id[7] = (day + " + Eighth = name");
        id[8] = (day + " + Ninth = name");
        id[9] = (day + " + Tenth = name");
        id[10] = (day + " + Eleventh = name");
        id[11] = (day + " + Twelfth = name");
        DataPersistenceManager.instance.loadGame();
    }

    public void LoadData(GameData data)
    {
        if(data.SavedData.TryGetValue(id[0], out string name1))
        {
            this.Name[0] = name1;
        }
        if (data.SavedData.TryGetValue(id[1], out string name2))
        {
            this.Name[1] = name2;
        }
        if (data.SavedData.TryGetValue(id[2], out string name3))
        {
            this.Name[2] = name3;
        }
        if (data.SavedData.TryGetValue(id[3], out string name4))
        {
            this.Name[3] = name4;
        }
        if (data.SavedData.TryGetValue(id[4], out string name5))
        {
            this.Name[4] = name5;
        }
        if (data.SavedData.TryGetValue(id[5], out string name6))
        {
            this.Name[5] = name6;
        }
        if (data.SavedData.TryGetValue(id[6], out string name7))
        {
            this.Name[6] = name7;
        }
        if (data.SavedData.TryGetValue(id[7], out string name8))
        {
            this.Name[7] = name8;
        }
        if (data.SavedData.TryGetValue(id[8], out string name9))
        {
            this.Name[8] = name9;
        }
        if (data.SavedData.TryGetValue(id[9], out string name10))
        {
            this.Name[9] = name10;
        }
        if (data.SavedData.TryGetValue(id[10], out string name11))
        {
            this.Name[10] = name11;
        }
        if (data.SavedData.TryGetValue(id[11], out string name12))
        {
            this.Name[11] = name12;
        }
    }
    
    public void SaveData(GameData data)
    {

    }

    void Update()
    {
        actualtext[0].text = (Name[0]);
        actualtext[1].text = (Name[1]);
        actualtext[2].text = (Name[2]);
        actualtext[3].text = (Name[3]);
        actualtext[4].text = (Name[4]);
        actualtext[5].text = (Name[5]);
        actualtext[6].text = (Name[6]);
        actualtext[7].text = (Name[7]);
        actualtext[8].text = (Name[8]);
        actualtext[9].text = (Name[9]);
        actualtext[10].text = (Name[10]);
        actualtext[11].text = (Name[11]);
    }
}



