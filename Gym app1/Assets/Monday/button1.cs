using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    [SerializeField] Delete delete;
        
    public void changebutton()
    {
        if (delete.edit2 == true)
        {
            delete.edit2 = false;            
            gameObject.SetActive(false);
        }
    }
}
