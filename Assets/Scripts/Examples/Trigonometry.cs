using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    public Transform obj;

    public Vector2 startPos, amplitude, frequency;

    // Update is called once per frame
    void Update()
    {
        //Sine();
        //Cosine();
        //Tangent();
        Ellipse();
    }

    void Sine()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Sin(frequency.y * Time.timeSinceLevelLoad);

        obj.position = new Vector2(xPos, yPos);
    }

    void Cosine()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Cos(frequency.y * Time.timeSinceLevelLoad);

        obj.position = new Vector2(xPos, yPos);
    }

    void Tangent()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Tan(frequency.y * Time.timeSinceLevelLoad);

        obj.position = new Vector2(xPos, yPos);
    }

    void Ellipse()
    {
        float xPos = startPos.x + amplitude.x * Mathf.Sin(frequency.x * Time.timeSinceLevelLoad);
        float yPos = startPos.x + amplitude.x * Mathf.Cos(frequency.y * Time.timeSinceLevelLoad);

        amplitude.x += Time.timeSinceLevelLoad * 0.0001f;

        obj.position = new Vector2(xPos, yPos);
    }
}
