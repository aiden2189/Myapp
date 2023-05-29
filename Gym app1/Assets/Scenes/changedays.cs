using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changedays : MonoBehaviour
{
    public void Change()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(1);
    }
    public void Back()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(0);
    }
}
