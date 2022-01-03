using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speedX = 0.0f;
    public float speedY = 0.0f;
    public float speedZ = 4.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 speed = new Vector3(speedX, speedY, speedZ);
        transform.Translate(speed * Time.deltaTime, Space.Self);

    }
}
