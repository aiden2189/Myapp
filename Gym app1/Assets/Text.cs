using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public GameObject text1;
    TextMeshProUGUI text4;
    void Start()
    {
        text4 = text1.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text4.text = ("Shots fired ");
    }
}
