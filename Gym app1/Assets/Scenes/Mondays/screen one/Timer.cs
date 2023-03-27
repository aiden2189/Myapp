using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float seconds;
    public float minutes;

    public bool start;

    public GameObject cancel;

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

    public void cancelbutton()
    {
        minutes = 0;
        seconds = 0;
    }

    void Update()
    {
        if (start == false && seconds == 60)
        {
            minutes = minutes + 1;
            seconds = seconds - 60;
        }
        if (start == false && seconds < 0 && minutes > 0)
        {
            minutes = minutes - 1;
            seconds = 30;
        }
        if (seconds < 0 && minutes == 0)
        {
            seconds = 0;
            start = false;
        }

        if (start == true && seconds < 0 && minutes > 0)
        {
            minutes = minutes - 1;
            seconds = seconds + 60;
        }

        if (start == true)
        {
            seconds = seconds - 1 * Time.deltaTime;
            cancel.gameObject.SetActive(true);
        }
        else
        {
            start = false;
            cancel.gameObject.SetActive(false);
        }

        actualtext1.text = (minutes.ToString() + ": "+ seconds.ToString("F0"));
    }    
}
