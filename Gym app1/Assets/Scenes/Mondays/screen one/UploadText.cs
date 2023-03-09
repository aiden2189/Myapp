using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText : MonoBehaviour, IDataPersistence
{
    public TMP_InputField inputField;

    public GameObject text1;
    TextMeshProUGUI actualtext1;

    public string name;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.name = data.name;
    }

    public void SaveData(ref GameData data)
    {
        data.name = this.name;
    }
    
    public void Setname()
    {
        name = inputField.text;
    }

    void Update()
    {
        actualtext1.text = (name.ToString());
    }
}
