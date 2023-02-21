using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReceiveText : MonoBehaviour
{
    public TextMeshProUGUI showname;
    public bool on;

    public void turn()
    {
        on = true;
    }

    public void Awake()
    {
        if (on == true)
        {
            showname.text = UploadText.upload.name;
        }
        
    }
}
