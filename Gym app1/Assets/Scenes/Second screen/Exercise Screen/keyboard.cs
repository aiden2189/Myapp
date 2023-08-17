using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[ExecuteInEditMode]
public class keyboard : MonoBehaviour
{
    public GameObject activeweight;
    public GameObject activerep;

    public GameObject[] Objects;
    public RectTransform[] Key = new RectTransform[67];
    public TMP_Text[] text = new TMP_Text[27];

    public TMP_InputField[] textinput;

    public TMP_Text text1;
    public TMP_Text text2;
    public string location1;
    public string location2;
    public GameObject textObject1;
    public GameObject textObject2;

    public Button[] numbutton = new Button[14];

    public Button[] button = new Button[26];
    private ColorBlock buttonColor;

    public RectTransform weight;

    public RectTransform reps;

    public bool shift;
    public bool Caplock;
    public bool Weight;
    public bool Rep;

    public int w;
    public int h;

    public int count;
    public int count1;

    void Start()
    {
        Key = Objects[9].GetComponentsInChildren<RectTransform>();
        text = Objects[9].GetComponentsInChildren<TMP_Text>();
        button = Objects[9].GetComponentsInChildren<Button>();
        numbutton = Objects[11].GetComponentsInChildren<Button>();

        for (int i = 0; i < 26; i++)
        {
            button[i].onClick.AddListener(ButtonPressed);
        }

        for (int i = 0; i < 10; i++)
        {
            numbutton[i].onClick.AddListener(numButtonPressed);
        }

    }




    public void NumSelected()
    {
        //AlwaysShowing
        Objects[0].gameObject.SetActive(false);
        //Submit
        Objects[1].gameObject.SetActive(false);
        //Submit
        Objects[2].gameObject.SetActive(false);
        //Number Keyboards All Parts
        Objects[10].gameObject.SetActive(true);
        //Number Keyboards
        Objects[11].gameObject.SetActive(true);

        weight.anchoredPosition = new Vector2(-280, 100);
        weight.sizeDelta = new Vector2(200, 200);
        reps.anchoredPosition = new Vector2(280, 100);
        reps.sizeDelta = new Vector2(200, 200);
    }


    public void NumDeselected()
    {
        //AlwaysShowing
        Objects[0].gameObject.SetActive(true);
        //Submit
        Objects[1].gameObject.SetActive(true);
        //Submit
        Objects[2].gameObject.SetActive(true);
        //Number Keyboards All Parts
        Objects[10].gameObject.SetActive(false);
        //Number Keyboards
        Objects[11].gameObject.SetActive(false);

        weight.anchoredPosition = new Vector2(-250, 0);
        weight.sizeDelta = new Vector2(250, 200);
        reps.anchoredPosition = new Vector2(250, 0);
        reps.sizeDelta = new Vector2(250, 200);
    }

    public void DefSelected()
    {
        Invoke("BuildDefaultKeyBoard", 0);
        for (int i = 0; i < 55; i++)
        {
            Key[i].gameObject.SetActive(true);
        }

        //NextandBack
        Objects[3].gameObject.SetActive(false);
        //Back To exercise screen
        Objects[4].gameObject.SetActive(false);
        //input screen
        Objects[5].gameObject.SetActive(false);
        //SpecialKeys
        Objects[8].gameObject.SetActive(true);
        //Default KeyBoards
        Objects[9].gameObject.SetActive(true);
    }


    public void DefDeselected()
    {
        for (int i = 0; i < 55; i++)
        {
            Key[i].gameObject.SetActive(false);
        }

        //NextandBack
        Objects[3].gameObject.SetActive(true);
        //Back To exercise screen
        Objects[4].gameObject.SetActive(true);
        //input screen
        Objects[5].gameObject.SetActive(true);
        //SpecialKeys
        Objects[8].gameObject.SetActive(false);
        //Default KeyBoards
        Objects[9].gameObject.SetActive(false);
    }

    void BuildDefaultKeyBoard()
    {

        for (int i = 0; i < 26; i++)
        {
            //changing the color
            buttonColor = button[i].GetComponent<Button>().colors;
            buttonColor.highlightedColor = Color.grey;
            buttonColor.normalColor = Color.white;
            buttonColor.pressedColor = Color.black;
            buttonColor.colorMultiplier = 1;
            button[i].colors = buttonColor;
        }
    }

    public void ButtonPressed()
    {
        string location1 = EventSystem.current.currentSelectedGameObject.name;
        textObject1 = GameObject.Find(location1);
        string text1 = textObject1.GetComponentInChildren<TextMeshProUGUI>().text;
        
        if (shift == true|| Caplock == true)
        {
            textinput[0].text += text1.ToUpper();
        }
        else
        {
            textinput[0].text += text1;
        }

        shift = false;
        Objects[7].GetComponent<Image>().color = Color.white;
    }

    public void numButtonPressed()
    {
        string location2 = EventSystem.current.currentSelectedGameObject.name;
        textObject2 = GameObject.Find(location2);
        string text2 = textObject2.GetComponentInChildren<TextMeshProUGUI>().text;
        if (Weight)
        {
            textinput[1].text += text2;
        }
        if (Rep)
        {
            textinput[2].text += text2;
        }
    }
    
    void Update()
    {
        if (Weight)
        {
            activeweight.GetComponent<Image>().color = Color.red;
            activerep.GetComponent<Image>().color = Color.white;
        }
        if (Rep)
        {
            activerep.GetComponent<Image>().color = Color.red;
            activeweight.GetComponent<Image>().color = Color.white;  
        }
    }

    public void weightActive()
    {        
        Weight = true;
        Rep = false;
    }

    public void repActive()
    {
        Rep = true;
        Weight = false;
    }
    
    public void Done()
    {
        Rep = false;
        Weight = false;
        activerep.GetComponent<Image>().color = Color.white;
        activeweight.GetComponent<Image>().color = Color.white;
    }

    public void Submit()
    {
        textinput[1].text = "";
        textinput[2].text = "";
    }

    public void numBackSpace()
    {
        if (Weight)
        {
            if (textinput[1].text.Length > 0)
            {
                textinput[1].text = textinput[1].text.Substring(0, textinput[1].text.Length - 1);
            }
        }
        if (Rep)
        {
            if (textinput[2].text.Length > 0)
            {
                textinput[2].text = textinput[2].text.Substring(0, textinput[2].text.Length - 1);
            }
        }


    }

    public void BackSpace()
    {
        if(textinput[0].text.Length > 0)
        {
            textinput[0].text = textinput[0].text.Substring(0, textinput[0].text.Length - 1);
        }
    }

    public void Space()
    {
        textinput[0].text += " ";
    }

    public void Shift()
    {
        shift = true;

        Objects[7].GetComponent<Image>().color = Color.red;
    }

    public void CapLock()
    {
        if (Caplock)
        {   
            Caplock = false;
            Objects[6].GetComponent<Image>().color = Color.white;
        }
        else
        {               
            Caplock = true;
            Objects[6].GetComponent<Image>().color = Color.red;
        }

        
    }
}
