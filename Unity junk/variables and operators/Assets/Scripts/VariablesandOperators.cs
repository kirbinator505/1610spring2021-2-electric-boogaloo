using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandOperators : MonoBehaviour
{
    private int one = 2, two = 7;
    private char first = 'a', second = 'b';
    private float primary = 5.3f, secondary = 2.6f;
    private string beginning = "Black", end = "berry";
    void Start()
    {
        Debug.Log("int one = 2, int two = 7");
        Debug.Log("one + two equals " + (one+two));
        Debug.Log("two - one equals " + (two-one));
        Debug.Log("one * two equals " + (one*two));
        Debug.Log("two / one equals " + (two/one));
        Debug.Log("two % one equals " + (two%one));
        Debug.Log("char first = a, char second = b");
        Debug.Log("first + second equals " +(first)+(second));
        Debug.Log("float primary = 5.3f, float secondary = 2.6f");
        Debug.Log("primary + secondary equals " + (primary+secondary));
        Debug.Log("string beginning = Black, string end = berry");
        Debug.Log("beginning + end equals " + (beginning+end));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
