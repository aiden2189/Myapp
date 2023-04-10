using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField inputField;

    public GameObject text;

    TextMeshProUGUI actualtext1;

    public string[] Name = new string[2];

    void Start()
    {
        actualtext1 = text.GetComponent<TextMeshProUGUI>();
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
    
    public void Setname1()
    {
        Name[0] = inputField.text;
    }

    public void Setname2()
    {
        Name[1] = inputField.text;
    }

    void Update()
    {
        actualtext1.text = (Name[0].ToString());
    }
}
