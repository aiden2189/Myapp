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

    [SerializeField] Datainput1 script;
    public GameObject canvas;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneloaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneloaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    public void OnSceneloaded(Scene scene, LoadSceneMode mode)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Homescreen")
        {
            canvas = GameObject.Find("/Canvas/Monday");

            button1 = canvas.GetComponent<Button>();
            button1.onClick.AddListener(Monday);
        }

        if (sceneName == "Second Screen") 
        {   
            canvas = GameObject.Find("/Canvas/Buttons/Button (1)");
            
            button1 = canvas.GetComponent<Button>();
            button1.onClick.AddListener(First);
        }

        if (sceneName == "Exercise Screen") 
        {
            canvas = GameObject.Find("/Things");
            script = canvas.GetComponent<Datainput1>();
            script.id1 = ID;
        }
    }

    private void OnSceneUnloaded(Scene scene)
    {
        
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
        ID = (day + " + " + number + " + ");
    }
}
