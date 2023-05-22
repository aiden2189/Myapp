using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]

public class Datainput1 : MonoBehaviour, IDataPersistence
{
    public GameObject Screens;

    private TMP_InputField[] input;

    public GameObject[] text = new GameObject[9];

    private TextMeshProUGUI[] actualtext = new TextMeshProUGUI[9];

    public string[] Weight = new string[3];

    public string[] Rep = new string[3];

    private int count;

    [SerializeField] private string[] id = new string[6];

    private string ID;

    void Awake()
    {    
        input = Screens.GetComponentsInChildren<TMP_InputField>();
        text[0] = Screens.transform.Find("Input Screen/Input Weight/Text Area/WeightText").gameObject;
        text[1] = Screens.transform.Find("Input Screen/Input Rep/Text Area/RepText").gameObject;
        text[2] = Screens.transform.Find("log Screen/Weight (1)").gameObject;
        text[3] = Screens.transform.Find("log Screen/Weight (2)").gameObject;
        text[4] = Screens.transform.Find("log Screen/Weight (3)").gameObject;
        text[5] = Screens.transform.Find("log Screen/Reps (1)").gameObject;
        text[6] = Screens.transform.Find("log Screen/Reps (2)").gameObject;
        text[7] = Screens.transform.Find("log Screen/Reps (3)").gameObject;
        text[8] = Screens.transform.Find("Input Screen/Set").gameObject;

        actualtext[0] = text[0].GetComponent<TextMeshProUGUI>();
        actualtext[1] = text[1].GetComponent<TextMeshProUGUI>();
        actualtext[2] = text[2].GetComponent<TextMeshProUGUI>();
        actualtext[3] = text[3].GetComponent<TextMeshProUGUI>();
        actualtext[4] = text[4].GetComponent<TextMeshProUGUI>();
        actualtext[5] = text[5].GetComponent<TextMeshProUGUI>();
        actualtext[6] = text[6].GetComponent<TextMeshProUGUI>();
        actualtext[7] = text[7].GetComponent<TextMeshProUGUI>();
        actualtext[8] = text[8].GetComponent<TextMeshProUGUI>();

        id[0] = (ID + SceneManager.GetActiveScene().name + " = 1");
        id[1] = (ID + SceneManager.GetActiveScene().name + " = 2");
        id[2] = (ID + SceneManager.GetActiveScene().name + " = 3");
        id[3] = (ID + SceneManager.GetActiveScene().name + " = 4");
        id[4] = (ID + SceneManager.GetActiveScene().name + " = 5");
        id[5] = (ID + SceneManager.GetActiveScene().name + " = 6");
    }

    public void LoadData(GameData data)
    {
        if(data.SavedData.TryGetValue("password", out string Id))
        {
            this.ID = Id;
        } 
        if(data.SavedData.TryGetValue(id[0], out string weight1))
        {
            this.Weight[0] = weight1;
        } 
        if(data.SavedData.TryGetValue(id[1], out string weight2))
        {
            this.Weight[1] = weight2;
        } 
        if(data.SavedData.TryGetValue(id[2], out string weight3))
        {
            this.Weight[2] = weight3;
        } 
        if(data.SavedData.TryGetValue(id[3], out string rep1))
        {
            this.Rep[0] = rep1;
        } 
        if(data.SavedData.TryGetValue(id[4], out string rep2))
        {
            this.Rep[1] = rep2;
        } 
        if(data.SavedData.TryGetValue(id[5], out string rep3))
        {
            this.Rep[2] = rep3;
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
        
        if (data.SavedData.ContainsKey(id[3]))
        {
            data.SavedData.Remove(id[3]);
        }
        data.SavedData.Add(id[3], Rep[0]);

        if (data.SavedData.ContainsKey(id[4]))
        {
            data.SavedData.Remove(id[4]);
        }
        data.SavedData.Add(id[4], Rep[1]);

        if (data.SavedData.ContainsKey(id[5]))
        {
            data.SavedData.Remove(id[5]);
        }
        data.SavedData.Add(id[5], Rep[2]);
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