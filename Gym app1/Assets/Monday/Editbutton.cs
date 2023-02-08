using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Editbutton : MonoBehaviour
{
    public GameObject delete;
    public GameObject change;
    void Start()
    {
        delete.gameObject.SetActive(false);
        change.gameObject.SetActive(false);     
    }

    public void edit()
    {
        delete.gameObject.SetActive(true);
        change.gameObject.SetActive(true);
    }
}
