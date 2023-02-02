using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    [SerializeField] Editbutton edit1;
    [SerializeField] Text1 turn;
        
    public void changebutton()
    {
        if (edit1.edit2 == true)
        {
            edit1.edit2 = false;            
            gameObject.SetActive(false);
        }
    }
}
