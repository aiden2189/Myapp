using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScreenNavagation : MonoBehaviour
{
    public int count;

    public RectTransform[] Buttons;

    public GameObject[] Button;

    public void next()
    {
        count = count + 1;
        Buttons[(count) - 1].anchoredPosition = new Vector2(0, 5000);
        if (count == 12)
        {
            count = 0;
        }
    }

    public void back()
    {               
        

        if (count == 0)
        {
            count = 11;
            Buttons[0].anchoredPosition = new Vector2(0, 5000);
        }
        else
        {
            count = count - 1;
            Buttons[(count) + 1].anchoredPosition = new Vector2(0, 5000);
        }
    }

    public void SeeAll()
    {
        count = 20;
        Button[0].gameObject.SetActive(false);
        Button[1].gameObject.SetActive(false);
        Button[2].gameObject.SetActive(false);
        Button[3].gameObject.SetActive(false);

        Button[4].gameObject.SetActive(true);

        Buttons[0].anchoredPosition = new Vector2(-425, 250);
        Buttons[1].anchoredPosition = new Vector2(-220, 250);
        Buttons[2].anchoredPosition = new Vector2(220, 250);
        Buttons[3].anchoredPosition = new Vector2(425, 250);

        Buttons[4].anchoredPosition = new Vector2(-425, 30);
        Buttons[5].anchoredPosition = new Vector2(-220, 30);
        Buttons[6].anchoredPosition = new Vector2(220, 30);
        Buttons[7].anchoredPosition = new Vector2(425, 30);

        Buttons[8].anchoredPosition = new Vector2(-425, -210); 
        Buttons[9].anchoredPosition = new Vector2(-220, -210);
        Buttons[10].anchoredPosition = new Vector2(220, -210);
        Buttons[11].anchoredPosition = new Vector2(425, -210); 
    }

    public void DontSeeAll()
    {
        count = 0;
        Button[0].gameObject.SetActive(true);
        Button[1].gameObject.SetActive(true);
        Button[2].gameObject.SetActive(true);
        Button[3].gameObject.SetActive(true);

        Button[4].gameObject.SetActive(false);

        for (int i = 1; i < 12; i++)
        {
            Buttons[i].anchoredPosition = new Vector2(0, 5000);
        }
    }

    void Update()
    {
        if (count != 20)
        {
            Buttons[count].anchoredPosition = new Vector2(0, 0);
        }                
    }
}
                                       