using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monday1 : MonoBehaviour
{

    public GameObject Canvas;
    public void NewGameButton()
    {

        foreach (Transform child in Canvas.GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = LayerMask.NameToLayer("onscreen"); 
        }

    }
}
//int Layeroffscreen = LayerMask.NameToLayer("offscreen");
//gameObject.layer = Layeroffscreen;