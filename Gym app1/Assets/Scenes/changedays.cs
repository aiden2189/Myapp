using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changedays : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene(1);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
