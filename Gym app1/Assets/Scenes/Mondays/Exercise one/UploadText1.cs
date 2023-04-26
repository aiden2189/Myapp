using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField[] inputField = new TMP_InputField[2];

    public GameObject[] text = new GameObject[2];

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[2];

    public string[] Name = new string[2];

    [SerializeField] public string[] id = new string[3];

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        data.SavedData.TryGetValue(id[0], out Name[0]);
        data.SavedData.TryGetValue(id[1], out Name[1]);
        if(Name[0] == "")
        {
            actualtext[0].text = Name[0];
            actualtext[1].text = Name[1];
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
    
    public void Setname1()
    {
        Name[0] = inputField[0].text;
    }

    public void Setname2()
    {
        Name[1] = inputField[1].text;
    }

    void Update()
    {
        actualtext[0].text = (Name[0]);
        actualtext[1].text = (Name[1]);
    }
}
