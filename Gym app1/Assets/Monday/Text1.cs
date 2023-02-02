using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text1 : MonoBehaviour
{
    public GameObject text1;
    [SerializeField] Editbutton edit1;    
    TextMeshProUGUI text4;
    public bool invis;

    void Start()
    {
        text4 = text1.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (edit1.edit2 == false)
        {
            text4.text = ("");
        }
        else
        {
            text4.text = ("Pick which to remove");
        }
    }
    public void changetext()
    {
        invis = false;
    }
}
