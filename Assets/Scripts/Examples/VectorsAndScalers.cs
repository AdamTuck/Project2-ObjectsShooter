using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorsAndScalers : MonoBehaviour
{

    public Vector2 position;

    public Vector3 rotationVector;

    public float scalar, rotation;

    public Transform obj;

    // Start is called before the first frame update
    void Start()
    {
        obj.position = scalar * position;
    }

    // Update is called once per frame
    void Update()
    {
        //obj.rotation = Quaternion.Euler(rotationVector);
        obj.rotation = Quaternion.Euler(0,0,rotation);
    }
}
