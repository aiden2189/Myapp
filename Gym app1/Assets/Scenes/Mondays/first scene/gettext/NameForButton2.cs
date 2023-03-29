using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameForButton2 : MonoBehaviour, IDataPersistence
{
    public GameObject text1;
    TextMeshProUGUI actualtext1;

    public string name2;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.name2 = data.name2;
    }

    public void SaveData(ref GameData data)
    {
        data.name2 = this.name2;
    }

    void Update()
    {
        actualtext1.text = (name2.ToString());
    }
}
