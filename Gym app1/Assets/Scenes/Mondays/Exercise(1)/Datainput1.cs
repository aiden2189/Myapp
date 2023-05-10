using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Datainput1 : MonoBehaviour, IDataPersistence
{
    public GameObject Inputscreen;

    private TMP_InputField[] input;

    public GameObject[] text = new GameObject[9];

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[9];

    public string[] Weight = new string[3];

    public string[] Rep = new string[3];

    private int count;

    [SerializeField] private string[] id = new string[3];

    void Start()
    {    
        input = Inputscreen.GetComponentsInChildren<TMP_InputField>();
        text[0] = Inputscreen.transform.Find("Input Weight/Text Area/WeightText").gameObject;
        text[1] = Inputscreen.transform.Find("Input Rep/Text Area/RepText").gameObject;
        text[2] = Inputscreen.transform.Find("log Screen/Weight (1)").gameObject;
        text[3] = Inputscreen.transform.Find("log Screen/Weight (2)").gameObject;
        text[4] = Inputscreen.transform.Find("log Screen/Weight (3)").gameObject;
        text[5] = Inputscreen.transform.Find("log Screen/Reps (1)").gameObject;
        text[6] = Inputscreen.transform.Find("log Screen/Reps (2)").gameObject;
        text[7] = Inputscreen.transform.Find("log Screen/Reps (3)").gameObject;
        text[8] = Inputscreen.transform.Find("Set").gameObject;

        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[4] = text[4].GetComponent<TextMeshProUGUI>();
        actualtext[5] = text[5].GetComponent<TextMeshProUGUI>();
        actualtext[6] = text[6].GetComponent<TextMeshProUGUI>();
        actualtext[7] = text[7].GetComponent<TextMeshProUGUI>();
        actualtext[8] = text[8].GetComponent<TextMeshProUGUI>();

        id[0] = (SceneManager.GetActiveScene().name + " = 1");
        id[1] = (SceneManager.GetActiveScene().name + " = 2");
        id[2] = (SceneManager.GetActiveScene().name + " = 3");
    }

    public void LoadData(GameData data)
    {
        bool hasValue = data.SavedData.TryGetValue(id[0], out Weight[0]);
        if(hasValue)
        {
            this.Weight[0] = Weight[0];

            Debug.Log(Weight[0]);
            Debug.Log("true");
        }
        else if (data.SavedData.TryGetValue(id[0], out Weight[0]) == false)
        {
            Debug.Log("false");
        }

        data.SavedData.TryGetValue(id[1], out Weight[1]);
        if(Weight[1] != "")
        {
            actualtext[3].text = Weight[1];
        }

        data.SavedData.TryGetValue(id[1], out Weight[1]);
        if(Weight[2] != "")
        {
            actualtext[4].text = Weight[2];
        }
    }

    public void SaveData(GameData data)
    {
        if (data.SavedData.ContainsKey(id[0]))
        {
            data.SavedData.Remove(id[0]);
        }
        data.SavedData.Add(id[0], Weight[0]);
        if (data.SavedData.ContainsKey(id[1]))
        {
            data.SavedData.Remove(id[1]);
        }
        data.SavedData.Add(id[1], Weight[1]);
        if (data.SavedData.ContainsKey(id[2]))
        {
            data.SavedData.Remove(id[2]);
        }
        data.SavedData.Add(id[2], Weight[2]);
    }

    public void Countup()
    {
        count = count + 1;
        if (count == 1)
        {
            Weight[0] = actualtext[0].text;
            Rep[0] = actualtext[1].text;
        }
        else if (count == 2)
        {
            Weight[1] = actualtext[0].text;
            Rep[1] = actualtext[1].text;
        }
        else if (count == 3)
        {
            Weight[2] = actualtext[0].text;
            Rep[2] = actualtext[1].text;
            count = 0;
        }
        input[0].text = ("");
        input[1].text = ("");
    }

    void Update()
    {
        actualtext[2].text = Weight[0];
        actualtext[3].text = Weight[1];
        actualtext[4].text = Weight[2];
        actualtext[5].text = Rep[0];
        actualtext[6].text = Rep[1];
        actualtext[7].text = Rep[2];
        actualtext[8].text = ((count+1).ToString());   
    }
}