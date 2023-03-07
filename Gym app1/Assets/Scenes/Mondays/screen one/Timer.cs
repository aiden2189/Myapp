using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float time;

    private bool start;

    public GameObject text1;

    TextMeshProUGUI actualtext1;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }
    
    public void Plus()
    {
        time = time + 30;
    }

    public void Minus()
    {
        time = time - 30;
    }

    public void starttimer()
    {
        start = true;
    }
    void Update()
    {
        if (start == true)
        {
            time = time - 1 * Time.deltaTime;
        }
        else if (time == 0)
        {
            start = false;
        }
        actualtext1.text = (time.ToString("F0"));
    }    
}
