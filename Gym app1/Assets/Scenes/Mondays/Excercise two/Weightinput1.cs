using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weightinput1 : MonoBehaviour
{
    public TMP_InputField input;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    public string texta;

    TextMeshProUGUI actualtext1;
    TextMeshProUGUI actualtext2;
    TextMeshProUGUI actualtext3;
    TextMeshProUGUI actualtext4;

    public float count;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
        actualtext2 = text2.GetComponent<TextMeshProUGUI>();
        actualtext3 = text3.GetComponent<TextMeshProUGUI>();
        actualtext4 = text4.GetComponent<TextMeshProUGUI>();
    }

    public void Countup()
    {   
        texta = actualtext1.text;
        count = count + 1;
        input.text = ("");
    }

    void Update()
    {
        if (count == 1)
        {
            actualtext2.text = texta;
        }
        else if (count == 2)
        {
            actualtext3.text = texta;
        }
        else if (count == 3)
        {
            actualtext4.text = texta;
        }
    }
}