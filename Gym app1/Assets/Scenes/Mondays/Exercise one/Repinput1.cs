using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Repinput1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField[] input;

    public GameObject[] text;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[5];

    public string[] rep = new string[3];

    public int count;

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[4] = text[4].GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.rep[0] = data.rep[0];
        this.rep[1] = data.rep[1];
        this.rep[2] = data.rep[2];
    }

    public void SaveData(ref GameData data)
    {
        data.rep[0] = this.rep[0];
        data.rep[1] = this.rep[1];
        data.rep[2] = this.rep[2];
    }

    public void Countup()
    {
        count = count + 1;
        input[0].text = ("");
        actualtext[4].text = (count.ToString());
    }

    void Update()
    {
        if (count == 0)
        {
            rep[0] = actualtext[0].text;
        }
        else if (count == 1)
        {
            rep[1] = actualtext[0].text;
        }
        else if (count == 2)
        {
            rep[2] = actualtext[0].text;
        }

        actualtext[1].text = rep[0];
        actualtext[2].text = rep[1];
        actualtext[3].text = rep[2];
    }
}