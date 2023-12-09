using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefsTest : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TMP_Text txtDisplay;

    public void SaveData()
    {
        PlayerPrefs.SetString("SAVED_DATA", input.text);
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("SAVED_DATA"))
            txtDisplay.text = PlayerPrefs.GetString("SAVED_DATA");
        else
            Debug.Log("No data to load");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
