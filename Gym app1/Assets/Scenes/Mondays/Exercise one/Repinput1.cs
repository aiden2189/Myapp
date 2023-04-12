using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Repinput1 : MonoBehaviour, IDataPersistence
{
    public TMP_InputField[] input;

    public GameObject[] text;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[5];

    public string[] Rep = new string[3];

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
        this.Rep[0] = data.rep[0];
        this.Rep[1] = data.rep[1];
        this.Rep[2] = data.rep[2];
    }

    public void SaveData(GameData data)
    {
        data.rep[0] = this.Rep[0];
        data.rep[1] = this.Rep[1];
        data.rep[2] = this.Rep[2];
    }

    public void Countup()
    {
        count = count + 1;
        if (count == 1)
        {
            Rep[0] = actualtext[0].text;
        }
        else if (count == 2)
        {
            Rep[1] = actualtext[0].text;
        }
        else if (count == 3)
        {
            Rep[2] = actualtext[0].text;
        }

        input[0].text = ("");
    }

    void Update()
    {
        actualtext[1].text = Rep[0];
        actualtext[2].text = Rep[1];
        actualtext[3].text = Rep[2];
        actualtext[4].text = ((count+1).ToString());   
    }
}