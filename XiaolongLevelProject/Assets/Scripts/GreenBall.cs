using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour
{

    private void Start()
    {
        transform.position = transform.position + new Vector3(2, 3, 0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.01f);
        }
        
    }
}
