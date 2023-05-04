using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText1 : MonoBehaviour, IDataPersistence
{
    public GameObject Uploadtext;

    public GameObject UploadPlaceholder;

    public TMP_InputField inputField;

    private TextMeshProUGUI actualtext;

    public string Name;

    [SerializeField] public string id;

    void Start()
    {
        inputField = Uploadtext.GetComponent<TMP_InputField>();

        UploadPlaceholder = Uploadtext.transform.Find("Text Area/uploadPlaceholder").gameObject;
;

        actualtext = UploadPlaceholder.GetComponent<TextMeshProUGUI>();
    }

    public void Setname1()
    {
        Name = inputField.text;
    }

    public void LoadData(GameData data)
    {
        data.SavedData.TryGetValue(id, out Name);
        if(Name != "")
        {
            actualtext.text = Name;
        }
    }

    public void SaveData(GameData data)
    {
        if (data.SavedData.ContainsKey(id))
        {
            data.SavedData.Remove(id);
        }
        data.SavedData.Add(id, Name);
    }
    
    void Update()
    {
        actualtext.text = Name;
    }
}
