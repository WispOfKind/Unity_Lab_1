using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereIncreasing : MonoBehaviour
{
    public float X = 1;
    public float Y = 1;
    public float Z = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X += 0.0003f;
        Y += 0.0003f;
        Z += 0.0003f;
        transform.localScale = new Vector3 (X, Y, Z);
        
    }
}
