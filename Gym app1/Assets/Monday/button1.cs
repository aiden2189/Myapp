using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public addexercise count2;
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if(count1.count2 == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
