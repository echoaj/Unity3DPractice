using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] //new
    private Material mat;
    List<Color> colors = new List<Color>();

    private int index = 0;  // new

    void Start()
    {
        mat.color = Color.white;
        colors.Add(Color.red);
        colors.Add(Color.blue);
        colors.Add(Color.black);
        colors.Add(Color.green);
        colors.Add(Color.white);
        StartCoroutine("ChangeColor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {
            mat.color = colors[index % 5];  // new
            yield return new WaitForSeconds(1.0f);
            index += 1; //new
        }
    }
}
