using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameForButton1 : MonoBehaviour, IDataPersistence
{
    public GameObject[] text;

    TextMeshProUGUI actualtext1;
    TextMeshProUGUI actualtext2;

    public string[] name = new string[2];

    void Start()
    {
        actualtext1 = text[0].GetComponent<TextMeshProUGUI>();
        actualtext2 = text[1].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.name[0] = data.name[0];
        this.name[1] = data.name[1];
    }

    public void SaveData(ref GameData data)
    {
        data.name[0] = this.name[0];
        data.name[1] = this.name[1];
    }

    void Update()
    {
        actualtext1.text = (name[0].ToString());
        actualtext2.text = (name[1].ToString());
    }
}


