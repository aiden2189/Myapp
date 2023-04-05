using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weightinput1 : MonoBehaviour
{
    public TMP_InputField[] input;

    public GameObject[] text;

    public string texta;

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[5];

    public float count;

    void Start()
    {
        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
    }

    public void Countup()
    {   
        texta = actualtext[0].text;
        count = count + 1;
        input[0].text = ("");
    }

    void Update()
    {
        if (count == 1)
        {
            actualtext[1].text = texta;
        }
        else if (count == 2)
        {
            actualtext[2].text = texta;
        }
        else if (count == 3)
        {
            actualtext[3].text = texta;
        }
    }
}