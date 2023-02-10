using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene2 : MonoBehaviour
{
    public TextMeshProUGUI showname;

    public void Awake()
    {
        showname.text = Scene1.scene1.name;
    }
}
