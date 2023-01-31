using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addexercise : MonoBehaviour
{
    public float count1;
    public void NewGameButton()
    {
        if (count1 < 9)
        {
            count1 = count1 + 1;
        }
    }
}

