using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(1);
    }    
    public void loadfirstbutton()
    {
        SceneManager.LoadScene(2);
    }
    public void loadsecondbutton()
    {
        SceneManager.LoadScene(3);
    }
}
