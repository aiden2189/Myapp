using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybutton : MonoBehaviour
{
    [SerializeField] Editbutton edit1;
    void Start()

    {
    }
    public void destroy()
    {
        if (edit1.edit2 == true)
        {
            Destroy(gameObject,0);
        }
    }
}
