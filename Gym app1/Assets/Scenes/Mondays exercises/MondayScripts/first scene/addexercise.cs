using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addexercise : MonoBehaviour
{
    public float count1;
    public bool switch1;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    void Start()
    {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
    }
    public void NewGameButton()
    {
        if (count1 < 9)
        {
            count1 = count1 + 1;
        }
        else
        {
            count1 = 0;
            switch1 = true;
        }

        if (count1 > 0)
        {
            if (count1 == 1)
            {
                button1.gameObject.SetActive(true);
            }
            if (count1 == 2)
            {
                button2.gameObject.SetActive(true);
            }            
            if (count1 == 3)
            {
                button3.gameObject.SetActive(true);
            }
            if (count1 == 4)
            {
                button4.gameObject.SetActive(true);
            }
            if (count1 == 5)
            {
                button5.gameObject.SetActive(true);
            }
            if (count1 == 6)
            {
                button6.gameObject.SetActive(true);
            }   
            if (count1 == 7)
            {
                button7.gameObject.SetActive(true);
            }
            if (count1 == 8)
            {
                button8.gameObject.SetActive(true);
            }
            if (count1 == 9)
            {
                button9.gameObject.SetActive(true);
            }
        }                                                           
    }
}                                        