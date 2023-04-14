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
        this.Weight[0] = data.weight3d[0,0,0];
        this.Weight[0] = data.weight3d[0,0,1];
        this.Weight[0] = data.weight3d[0,0,2];
    }

    public void SaveData(GameData data)
    {
        data.weight3d[0,0,0] = this.Weight[0];
        data.weight3d[0,0,1] = this.Weight[0];
        data.weight3d[0,0,2] = this.Weight[0];
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