using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time;
    public GameObject text1;
    TextMeshProUGUI actualtext1;

    void start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }

    public void Add()
    {
        time = time + 30;
    }

    public void Minus()
    {
        time = time - 30;
    }

    void Update()
    {
        actualtext1.text = ("hi");
    }    
}
