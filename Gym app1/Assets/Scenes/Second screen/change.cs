using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void Back()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(1);
    }    
    public void ExerciseScreen()
    {
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(2);
    }
}
