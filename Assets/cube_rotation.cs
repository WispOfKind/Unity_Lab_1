using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.03f, 0f, 0.02f);
    }
}
