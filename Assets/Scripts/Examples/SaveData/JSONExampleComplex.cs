using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONExampleComplex : MonoBehaviour
{
    SampleDataComplex sampleData;

    // Start is called before the first frame update
    void Start()
    {
        //sampleData = new SampleDataComplex();

        //sampleData.name = "Adam";

        //sampleData.address = new Address();
        //sampleData.address.city = "Vancouver";
        //sampleData.address.road = "Main St.";
        //sampleData.address.unit = 127;

        //sampleData.book = new Book[2];
        //sampleData.book[0] = new Book();
        //sampleData.book[0].bookAuthor = "Suzanne Collins";
        //sampleData.book[0].bookName = "A Tale of Songbirds and Snakes";
        //sampleData.book[0].isDigital = false;
        //sampleData.book[1] = new Book();
        //sampleData.book[1].bookAuthor = "Frank Herbert";
        //sampleData.book[1].bookName = "Dune";
        //sampleData.book[1].isDigital = true;

        //string data = JsonUtility.ToJson(sampleData);
        //Debug.Log($"JSON = {data}");

        string filePath = Path.Combine(Application.dataPath, "SaveData/sampleDataComplex.json");
        //File.WriteAllText(filePath, data);

        string textIn = File.ReadAllText(filePath);
        SampleDataComplex sampleDataIn = JsonUtility.FromJson<SampleDataComplex>(textIn);

        string nameFromFile = sampleDataIn.name;
        string bookName = sampleDataIn.book[0].bookName;

        Debug.Log(nameFromFile + " is currently reading: " + bookName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
