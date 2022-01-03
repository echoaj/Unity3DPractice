using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float x = 0.0f;
    public float y = 62.5f;
    private float z = 0.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
       
        Vector3 xyz = new Vector3(x, y, z); 

        transform.Rotate(xyz * Time.deltaTime, Space.Self);

    }
}


/*
 * floats
 * new Vector3
 * Time.deltaTime
 * variables - public
 * 
 * movement
 * Space.Self vs Space.World
 * Rotation around object
 */
