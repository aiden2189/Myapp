using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText : MonoBehaviour, IDataPersistence
{
    public TMP_InputField inputField;

    public string name;

    public void LoadData(GameData data)
    {
        this.name = data.name;
    }

    public void SaveData(ref GameData data)
    {
        data.name = this.name;
    }
    
    public void setname()
    {
        name = inputField.text;
    }
}
