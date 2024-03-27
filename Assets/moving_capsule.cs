using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_capsule : MonoBehaviour
{
    public Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = new Vector3 (0, 0.002f, 0);
        transform.Translate(direction);
    }
}
