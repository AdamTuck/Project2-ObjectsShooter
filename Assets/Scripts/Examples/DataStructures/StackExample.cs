using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    public Stack<GameObject> stackedObjects = new Stack<GameObject>();

    public GameObject prefab;

    GameObject tempObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Push elements to stack
        if (Input.GetKeyDown(KeyCode.A))
        {
            tempObj = Instantiate(prefab, transform);
            tempObj.transform.position = new Vector2(0, stackedObjects.Count-4);

            tempObj.name = "Stacked Object " + stackedObjects.Count;
            tempObj.GetComponent<SpriteRenderer>().color = Random.ColorHSV();

            stackedObjects.Push(tempObj);
            Debug.Log("Pushed: " + tempObj.name);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            var remObj = stackedObjects.Pop();
            Debug.Log("Popping: " + remObj.name);
            Destroy(remObj);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Peeking at top of stack: " + stackedObjects.Peek().name);
        }
    }
}