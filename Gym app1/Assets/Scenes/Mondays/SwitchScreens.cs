using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScreens : MonoBehaviour
{
    public GameObject start;
    public GameObject screen1;
    public GameObject screen2;
    public float change;

    public void up()
    {
        change = change + 1;
    }

    public void down()
    {
        change = change - 1;
    }

    void Update()
    {
        if (change == 0)
        {
            change = 3;
        }

        if (change == 1)
        {
            start.gameObject.SetActive(true);
        }
        else 
        {
            start.gameObject.SetActive(false);
        }

        if (change == 2)
        {
            screen1.gameObject.SetActive(true);
        }
        else 
        {
            screen1.gameObject.SetActive(false);
        }

        if (change == 3)
        {
            screen2.gameObject.SetActive(true);
        }
        else 
        {
            screen2.gameObject.SetActive(false);
        }

        if (change == 4)
        {
            change = 1;
        }
    }
}
