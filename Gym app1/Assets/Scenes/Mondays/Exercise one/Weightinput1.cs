using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weightinput1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField[] input;

    public GameObject[] text;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[4];

    public string[] Weight = new string[3];

    [SerializeField] private string id = 3;

    public int count;

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        data.SavedData.TryGetValue(id, out actualtext[1].text);
        if(actualtext[1].text > 0)
        {
            Weight[0] = actualtext[1].text;
        }

    }

    public void SaveData(GameData data)
    {
        if (data.SavedData.ContainsKey(id))
        {
            data.SavedData.Remove(id);
        }
        data.SavedData.Add(id, actualtext[1].text);
    }

    public void Countup()
    {
        count = count + 1;
        if (count == 1)
        {
            Weight[0] = actualtext[0].text;
        }
        else if (count == 2)
        {
            Weight[0] = actualtext[0].text;
        }
        else if (count == 3)
        {
            Weight[0] = actualtext[0].text;
            count = 0;
        }

        input[0].text = ("");
    }

    void Update()
    {
        actualtext[1].text = Weight[0];
        actualtext[2].text = Weight[0];
        actualtext[3].text = Weight[0];
    }
}