using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAndBack : MonoBehaviour
{
    public RectTransform[] Buttons;

    public int count;

    public void next()
    {
        count = count + 1;
        Buttons[(count)-1].anchoredPosition = new Vector2(0, 8000);
        if (count == 7)
        {
            count = 0;
        }

    }

    public void back()
    {       
        if (count == 0)
        {
            count = 6;
            Buttons[0].anchoredPosition = new Vector2(0, 8000);
        }        
        else
        {
            count = count - 1;
            Buttons[(count) + 1].anchoredPosition = new Vector2(0, 8000);
        } 
   
    }

    void Update()
    {
        Buttons[count].anchoredPosition = new Vector2(0, 0);
    }
}
