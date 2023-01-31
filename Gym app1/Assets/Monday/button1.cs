using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    [SerializeField] addexercise count1;
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if(count.count1 == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
