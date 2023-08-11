using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UploadText1 : MonoBehaviour, IDataPersistence
{
    public GameObject AlwaysShowing;

    private GameObject UploadPlaceholder;

    private TMP_InputField inputField;

    private TextMeshProUGUI actualtext;

    public string Name;

    public string id3;

    [SerializeField] public string id;

    void Awake()
    {
        inputField = AlwaysShowing.GetComponentInChildren<TMP_InputField>();

        UploadPlaceholder = AlwaysShowing.transform.Find("UploadText/Text Area/uploadPlaceholder").gameObject;

        actualtext = UploadPlaceholder.GetComponent<TextMeshProUGUI>();
    }
    
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
        id = (id3 + " = name");
        DataPersistenceManager.instance.loadGame();
    }

    public void Setname1()
    {
        Name = inputField.text;
    }

    public void LoadData(GameData data)
    {
        if(data.SavedData.TryGetValue(id, out string name))
        {
            this.Name = name;
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
