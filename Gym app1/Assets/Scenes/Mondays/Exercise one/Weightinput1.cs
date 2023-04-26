using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weightinput1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField[] input;

    public GameObject[] text;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[4];

    public string[] Weight = new string [3];

    [SerializeField] private string[] id = new string[3];

    [ContextMenu("Generate guid for id")]

    private void GenerateGuid()
    {
        id[0] = System.Guid.NewGuid().ToString();
        id[1] = System.Guid.NewGuid().ToString();
        id[2] = System.Guid.NewGuid().ToString();
    }

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
        data.SavedData.TryGetValue(id[0], out Weight[0]);
        data.SavedData.TryGetValue(id[1], out Weight[1]);
        data.SavedData.TryGetValue(id[2], out Weight[2]);
        if(Weight[0] == "")
        {
            actualtext[1].text = Weight[0];
            actualtext[2].text = Weight[1];
            actualtext[3].text = Weight[2];
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
        if (data.SavedData.ContainsKey(id[2]))
        {
            data.SavedData.Remove(id[2]);
        }
        data.SavedData.Add(id[0], Weight[0]);
        data.SavedData.Add(id[1], Weight[1]);
        data.SavedData.Add(id[2], Weight[2]);
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
            Weight[1] = actualtext[0].text;
        }
        else if (count == 3)
        {
            Weight[2] = actualtext[0].text;
            count = 0;
        }

        input[0].text = ("");
    }

    void Update()
    {
        actualtext[1].text = Weight[0];
        actualtext[2].text = Weight[1];
        actualtext[3].text = Weight[2];
    }
}