using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{    
    private int count;

    public void Increase()
    {
        count = count + 1;
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(sceneBuildIndex:count);
    }
    public void Decrease()
    {
        count = count - 1;
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(sceneBuildIndex:count);
    }    
}
