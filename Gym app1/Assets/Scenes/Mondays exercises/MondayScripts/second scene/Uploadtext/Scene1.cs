using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    public static Scene1 scene1;
    public TMP_InputField inputField;

    public string name;

    public void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void setname()
    {
        name = inputField.text;

        SceneManager.LoadSceneAsync("exercise(1)");
    }
}
