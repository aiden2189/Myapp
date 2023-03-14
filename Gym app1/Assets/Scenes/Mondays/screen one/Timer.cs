using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float seconds;
    private float minutes;

    private bool start;

    public GameObject text1;

    TextMeshProUGUI actualtext1;

    void Start()
    {
        actualtext1 = text1.GetComponent<TextMeshProUGUI>();
    }
    
    public void Plus()
    {
        seconds = seconds + 30;
    }

    public void Minus()
    {
        seconds = seconds - 30;
    }

    public void starttimer()
    {
        start = true;
    }
    void Update()
    {
        if (seconds >= 60)
        {
            seconds = seconds - 60;
            minutes = minutes + 1;
        }

        if (start == true)
        {
            seconds = seconds - 1 * Time.deltaTime;
        }
        else if (seconds < 0 && minutes > 0)
        {
            seconds = seconds + 59;
            minutes = minutes - 1;
        }
        
        if (seconds < 0 && minutes < 0)
        {
            start = false;
        }

        actualtext1.text = (minutes.ToString() + ": "+ seconds.ToString("F0"));
    }    
}
