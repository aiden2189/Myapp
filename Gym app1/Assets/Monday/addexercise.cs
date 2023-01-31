using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addexercise : MonoBehaviour
{
    public float count;
    public void NewGameButton()
    {
        if (count < 9)
        {
            count = count + 1;
        }

    }
}

