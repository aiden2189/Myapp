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

    public string name1;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.name1 = data.name1;
    }

    public void SaveData(ref GameData data)
    {
        data.name1 = this.name1;
    }
    
    public void Setname()
    {
        name1 = inputField.text;
    }

    void Update()
    {
        actualtext1.text = (name1.ToString());
    }
}
