using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCalculations : MonoBehaviour
{
    public float height;
    public float length;

    public float area;

    public static int randNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        CalculateArea();
        CalcRandNum();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static void CalcRandNum ()
    {
        randNum++;
        Debug.Log("Rand number: " + randNum);
    }

    void CalculateArea()
    {
        area = length * height;
        Debug.Log("Area = " + area);
    }
}