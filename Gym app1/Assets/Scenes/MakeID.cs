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
    public int count;

    [SerializeField] NameForButton1 script1;
    [SerializeField] Datainput1 script2;
    [SerializeField] UploadText1 script3;
    public GameObject canvas;
    public GameObject backpos;
    public Button backbut;
    public Button[] button = new Button[12];

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
            DataPersistenceManager.instance.loadGame();
            canvas = GameObject.Find("/Canvas");

            button = canvas.GetComponentsInChildren<Button>();
            button[0].onClick.AddListener(Monday);
            button[1].onClick.AddListener(Tuesday);
            button[2].onClick.AddListener(Wednesday);
            button[3].onClick.AddListener(Thursday);
            button[4].onClick.AddListener(Friday);
            button[5].onClick.AddListener(Saturday);
            button[6].onClick.AddListener(Sunday);

            button[0].onClick.AddListener(Increase);
            button[1].onClick.AddListener(Increase);
            button[2].onClick.AddListener(Increase);
            button[3].onClick.AddListener(Increase);
            button[4].onClick.AddListener(Increase);
            button[5].onClick.AddListener(Increase);
            button[6].onClick.AddListener(Increase);
            button[6].onClick.AddListener(Increase);
        }

        if (sceneName == "Second Screen") 
        {
            DataPersistenceManager.instance.loadGame();
            canvas = GameObject.Find("/Canvas/Buttons");
            backpos = GameObject.Find("/Canvas/Back To Home");
            backbut = backpos.GetComponent<Button>();

            script1 = canvas.GetComponent<NameForButton1>();
            script1.day = day;

            button = canvas.GetComponentsInChildren<Button>();
            button[0].onClick.AddListener(First);
            button[1].onClick.AddListener(Second);
            button[2].onClick.AddListener(Third);
            button[3].onClick.AddListener(Forth);
            button[4].onClick.AddListener(Fifth);
            button[5].onClick.AddListener(Sixth);
            button[6].onClick.AddListener(Seventh);
            button[7].onClick.AddListener(Eighth);
            button[8].onClick.AddListener(Ninth);
            button[9].onClick.AddListener(Tenth);
            button[10].onClick.AddListener(Eleventh);
            button[11].onClick.AddListener(Twelfth);

            button[0].onClick.AddListener(Increase);
            button[1].onClick.AddListener(Increase);
            button[2].onClick.AddListener(Increase);
            button[3].onClick.AddListener(Increase);
            button[4].onClick.AddListener(Increase);
            button[5].onClick.AddListener(Increase);
            button[6].onClick.AddListener(Increase);
            button[7].onClick.AddListener(Increase);
            button[8].onClick.AddListener(Increase);
            button[9].onClick.AddListener(Increase);
            button[10].onClick.AddListener(Increase);
            button[11].onClick.AddListener(Increase);
            backbut.onClick.AddListener(Decrease);

        }

        if (sceneName == "Exercise Screen") 
        {
            DataPersistenceManager.instance.loadGame();
            backpos = GameObject.Find("/Always showing/Back to exercise screen");
            backbut = backpos.GetComponent<Button>();
            backbut.onClick.AddListener(Decrease);
            canvas = GameObject.Find("/Things");
            script2 = canvas.GetComponent<Datainput1>();
            script3 = canvas.GetComponent<UploadText1>();
            script2.id2 = ID;
            script3.id3 = ID;
            
        }
    }

    public void Increase()
    {
        DataPersistenceManager.instance.SaveGame();
        count = count + 1;        
        SceneManager.LoadScene(sceneBuildIndex: count);
    }

    public void Decrease()
    {
        DataPersistenceManager.instance.SaveGame();
        count = count - 1;        
        SceneManager.LoadScene(sceneBuildIndex: count);
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
    public void Tenth()
    {
        number = "Tenth";
    }
    public void Eleventh()
    {
        number = "Eleventh";
    }
    public void Twelfth()
    {
        number = "Twelfth";
    }

    public void Update()
    {
        ID = (day + " + " + number);
    }
}
