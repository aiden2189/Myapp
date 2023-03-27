using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstchange : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(1);
    }    
    public void loadfirstbutton()
    {
        SceneManager.LoadScene(2);
    }
}
