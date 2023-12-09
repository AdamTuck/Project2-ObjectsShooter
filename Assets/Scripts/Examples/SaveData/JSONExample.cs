using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONExample : MonoBehaviour
{
    SampleData sampleData;

    // Start is called before the first frame update
    void Start()
    {
        sampleData = new SampleData();

        sampleData.name = "Adam";
        sampleData.score = 10.0f;

        string data = JsonUtility.ToJson(sampleData);

        Debug.Log($"JSON = {data}");

        string filePath = Path.Combine(Application.dataPath, "SaveData/sampleJSON.json");
        File.WriteAllText(filePath, data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
