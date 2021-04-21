using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(0.1f,0f,0f);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(-0.1f,0f,0f);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0f,0f,0.1f);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0f,0f,-0.1f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0f,0.1f,0f);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(0f,-0.1f,0f);
        }
    }
}
