using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DictionaryExample : MonoBehaviour
{
    public Dictionary<string, int> dictionary = new Dictionary<string, int>();

    [SerializeField] private TMP_Text txtTriangle, txtSquare, txtCircle;

    public string checkForKey = "Rectangle";

    // Start is called before the first frame update
    void Start()
    {
        dictionary.Add("Triangles", 0);
        dictionary.Add("Squares", 0);
        dictionary.Add("Circles", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (dictionary.ContainsKey("Triangles"))
            {
                dictionary["Triangles"]++;
                txtTriangle.text = dictionary["Triangles"].ToString();
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (dictionary.ContainsKey("Squares"))
            {
                dictionary["Squares"]++;
                txtSquare.text = dictionary["Squares"].ToString();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (dictionary.ContainsKey("Circles"))
            {
                dictionary["Circles"]++;
                txtCircle.text = dictionary["Circles"].ToString();
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            int val = 0;
            bool hasKey = dictionary.TryGetValue(checkForKey, out val);
            Debug.Log(hasKey + " - " + val);
        }
    }
}