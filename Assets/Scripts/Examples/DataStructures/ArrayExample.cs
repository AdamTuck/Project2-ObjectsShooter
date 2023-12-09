using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public int[] integerNumbers;
    public int[] newIntNumbers = new int[2];

    public GameObject[] gameObjectArray = new GameObject[2];
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        newIntNumbers[0] = 50;
        newIntNumbers[0] = 23;

        gameObjectArray[0] = Instantiate(prefab, transform);
        gameObjectArray[0].transform.position = new Vector2(0,0);

        gameObjectArray[1] = Instantiate(prefab, transform);
        gameObjectArray[1].transform.position = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            int index = Random.Range(0, gameObjectArray.Length);
            gameObjectArray[index].GetComponent<SpriteRenderer>().color = Random.ColorHSV();
            Debug.Log("Recolouring: " + gameObjectArray[index].name + " " + index);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            int index = Random.Range(0, gameObjectArray.Length);
            Destroy(gameObjectArray[index]);
            Debug.Log("Destroying: " + gameObjectArray[index].name + " " + index);
        }
    }
}
