using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    [SerializeField] Delete delete;
    public GameObject deletebutt;

    public void changebutton()
    {
        if (delete.edit2 == true)
        {
            deletebutt.gameObject.SetActive(false);
            delete.edit2 = false;            
            gameObject.SetActive(false);
        }
    }
}
