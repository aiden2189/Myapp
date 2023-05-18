using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameForButton1 : MonoBehaviour, IDataPersistence
{
    public GameObject[] text;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[2];

    public string[] Name = new string[2];

    public string[] id = new string[2];

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        if(data.SavedData.TryGetValue("Exercise(1) = name", out string name))
        {
            this.Name[0] = name;
        } 
    }
    
    public void SaveData(GameData data)
    {
        if (data.SavedData.ContainsKey(id[0]))
        {
            data.SavedData.Remove(id[0]);
        }
        if (data.SavedData.ContainsKey(id[1]))
        {
            data.SavedData.Remove(id[1]);
        }
        data.SavedData.Add(id[0], Name[0]);
        data.SavedData.Add(id[1], Name[1]);
    }

    void Update()
    {
        actualtext[0].text = (Name[0]);
        actualtext[1].text = (Name[1]);
    }
}


