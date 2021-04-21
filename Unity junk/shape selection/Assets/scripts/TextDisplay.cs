using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text display;
    public StringData word;
    
    void Update()
    {
        display.text = "You are in " + word.shape;
    }
}
