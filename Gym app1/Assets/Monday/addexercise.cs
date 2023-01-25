using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addexercise : MonoBehaviour
{
    public GameObject exercise;
    public GameObject canvas;
    public float x;
    public float y;
    public float count;
    public void NewGameButton()
    {
        if (count < 9)
        {
            count = count + 1;
            x = x + 400;
            if (x == 800)
            {
                x = -400;
                y = y - 400;
            }
        
            GameObject clone;
            clone = Instantiate(exercise, new Vector3(x, y, 0), transform.rotation,transform.parent);
            clone.transform.SetParent(canvas.transform, false);
        }

    }
}

