using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Datainput1 : MonoBehaviour, IDataPersistence
{
    public GameObject Inputscreen;

    public GameObject[] text;

    public TMP_InputField[] input = new TMP_InputField[2];

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[8];

    public string[] Weight = new string[3];

    public string[] Rep = new string[3];

    public int count;

    [SerializeField] private string[] id = new string[3];

    [ContextMenu("Generate guid for id")]

    private void GenerateGuid()
    {
        id[0] = System.Guid.NewGuid().ToString();
        id[1] = System.Guid.NewGuid().ToString();
        id[2] = System.Guid.NewGuid().ToString();
    }

    void Start()
    {
        TMP_InputField[] input = Inputscreen.GetComponents<TMP_InputField>();

        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[4] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[5] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[6] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[7] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[8] = text[0].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        data.SavedData.TryGetValue(id[0], out Weight[0]);
        if(Weight[0] != "")
        {
            actualtext[1].text = Weight[0];
        }

        data.SavedData.TryGetValue(id[1], out Weight[1]);
        if(Weight[1] != "")
        {
            actualtext[2].text = Weight[1];
        }

        data.SavedData.TryGetValue(id[1], out Weight[1]);
        if(Weight[2] != "")
        {
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
            Rep[0] = actualtext[0].text;
        }
        else if (count == 2)
        {
            Weight[1] = actualtext[0].text;
            Rep[1] = actualtext[0].text;
        }
        else if (count == 3)
        {
            Weight[2] = actualtext[0].text;
            Rep[2] = actualtext[0].text;
            count = 0;
        }

        input[0].text = ("");
        input[1].text = ("");
    }

    void Update()
    {
        actualtext[1].text = Weight[0];
        actualtext[2].text = Weight[1];
        actualtext[3].text = Weight[2];
        actualtext[4].text = Rep[0];
        actualtext[5].text = Rep[1];
        actualtext[6].text = Rep[2];
        actualtext[7].text = ((count+1).ToString());   
    }
}