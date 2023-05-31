using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakeID : MonoBehaviour
{
    public string ID;
    public string day;
    public string number;

    [SerializeField] NameForButton1 script1;
    [SerializeField] Datainput1 script2;
    [SerializeField] UploadText1 script3;
    public GameObject canvas;
    public Button[] button = new Button[9];
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneloaded;
    }

    public void OnSceneloaded(Scene scene, LoadSceneMode mode)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Homescreen")
        {
            canvas = GameObject.Find("/Canvas");

            button = canvas.GetComponentsInChildren<Button>();
            button[0].onClick.AddListener(Monday);
            button[1].onClick.AddListener(Tuesday);
            button[2].onClick.AddListener(Wednesday);
            button[3].onClick.AddListener(Thursday);
            button[4].onClick.AddListener(Friday);
            button[5].onClick.AddListener(Saturday);
            button[6].onClick.AddListener(Sunday);
        }

        if (sceneName == "Second Screen") 
        {   
            canvas = GameObject.Find("/Canvas/Buttons");
            script1 = canvas.GetComponent<NameForButton1>();
            script1.day = day;

            button = canvas.GetComponentsInChildren<Button>();
            button[0].onClick.AddListener(First);
            button[1].onClick.AddListener(Second);
            button[2].onClick.AddListener(Third);
            button[3].onClick.AddListener(Forth);
            button[4].onClick.AddListener(Fifth);
            button[5].onClick.AddListener(Sixth);
            button[6].onClick.AddListener(Eighth);
            button[7].onClick.AddListener(Ninth);
        }

        if (sceneName == "Exercise Screen") 
        {
            canvas = GameObject.Find("/Things");
            script2 = canvas.GetComponent<Datainput1>();
            script3 = canvas.GetComponent<UploadText1>();

            script2.id2 = ID;
            script3.id3 = ID;
            
        }
    }

    public void Monday()
    {
        day = "Monday";
    }
    public void Tuesday()
    {
        day = "Tuesday";
    }
    public void Wednesday()
    {
        day = "Wednesday";
    }
    public void Thursday()
    {
        day = "Thrusday";
    }
    public void Friday()
    {
        day = "Friday";
    }
    public void Saturday()
    {
        day = "Saturday";
    }
    public void Sunday()
    {
        day = "Sunday";
    }

    public void First()
    {
        number = "First";
    }
    public void Second()
    {
        number = "Second";
    }
    public void Third()
    {
        number = "Third";
    }
    public void Forth()
    {
        number = "Forth";
    }
    public void Fifth()
    {
        number = "Fifth";
    }
    public void Sixth()
    {
        number = "Sixth";
    }
    public void Seventh()
    {
        number = "Seventh";
    }
    public void Eighth()
    {
        number = "Eighth";
    }
    public void Ninth()
    {
        number = "Ninths";
    }

    public void Update()
    {
        ID = (day + " + " + number);
    }
}
