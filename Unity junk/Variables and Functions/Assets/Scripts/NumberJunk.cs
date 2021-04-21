using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberJunk : MonoBehaviour
{
    private int myint = 5;
    void Start()
    {
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);
    }

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}
