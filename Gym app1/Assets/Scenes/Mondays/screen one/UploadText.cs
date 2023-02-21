using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText : MonoBehaviour
{
    public static UploadText upload;
    public TMP_InputField inputField;

    public string name;

    private void Awake()
    {
        if (upload == null)
        {
            upload = this;
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

        SceneManager.LoadSceneAsync("Monday");
    }
}
