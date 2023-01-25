using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alldays : MonoBehaviour
{

    public GameObject Canvas;
    public void NewGameButton()
    {

        foreach (Transform child in Canvas.GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = LayerMask.NameToLayer("offscreen");
        }

    }
}