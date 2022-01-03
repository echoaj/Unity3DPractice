using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandShrink : MonoBehaviour
{

    private int timer = 0;
    public float speed = 0.05f;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 size = new Vector3(speed, 0.0f, 0.0f);

        // reverse
        if(timer == 100)
        {
            speed *= -1;
            timer = 0;
        }

        transform.localScale += size;
        timer += 1;
    }
}
