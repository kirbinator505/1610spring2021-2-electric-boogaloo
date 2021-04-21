using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    public BoolData detect;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        detect.value = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        detect.value = false;
    }
}
