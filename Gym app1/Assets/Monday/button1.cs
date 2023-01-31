using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    [SerializeField] Editbutton edit1;
 
    public void changebutton()
    {
        if (edit1.edit2 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
