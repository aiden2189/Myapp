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

    public string[] name = new string[2];

    void Start()
    {
        actualtext1 = text.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.name[0] = data.name[0];
        this.name[1] = data.name[1];
    }

    public void SaveData(GameData data)
    {
        data.name[0] = this.name[0];
        data.name[1] = this.name[1];
    }
    
    public void Setname1()
    {
        name[0] = inputField.text;
    }

    public void Setname2()
    {
        name[1] = inputField.text;
    }

    void Update()
    {
        actualtext1.text = (name[0].ToString());
    }
}
