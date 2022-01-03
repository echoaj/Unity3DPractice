using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public GameObject sun;
    public float speed = 20.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 pos = new Vector3(0.0f, 1.0f, 0.0f);    // Rotate around Sun's y axis
        transform.RotateAround(sun.transform.position, pos, speed * Time.deltaTime);

    }
}
