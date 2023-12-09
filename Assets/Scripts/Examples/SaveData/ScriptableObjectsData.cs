using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectsData : MonoBehaviour
{
    public ScriptableObjectSample sample;

    // Start is called before the first frame update
    void Start()
    {
        if (!sample)
            return;

        Debug.Log($"Loaded file with name: {sample.name} with a score of {sample.score} starting at {sample.startPosition}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
