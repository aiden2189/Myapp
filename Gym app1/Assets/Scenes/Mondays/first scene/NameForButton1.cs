using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameForButton1 : MonoBehaviour, IDataPersistence
{
    public GameObject[] text;

    public TextMeshProUGUI[] actualtext = new TextMeshProUGUI[2];


    public string[] Name = new string[2];

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.Name[0] = data.name[0];
        this.Name[1] = data.name[1];
    }

    public void SaveData(GameData data)
    {
        data.name[0] = this.Name[0];
        data.name[1] = this.Name[1];
    }

    void Update()
    {
        actualtext[0].text = (Name[0].ToString());
        actualtext[1].text = (Name[1].ToString());
    }
}


