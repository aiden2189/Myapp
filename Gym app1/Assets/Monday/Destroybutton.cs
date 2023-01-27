using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybutton : MonoBehaviour
{
    [SerializeField] GameObject edit1;
    public void destroy()
    {
        if (edit1.edit2 == true)
        {
            Destroy(gameObject,0);
        }
    }
}
