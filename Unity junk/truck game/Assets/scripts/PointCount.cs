using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    public int creditvalue = 3;
    public IntData numbercount;
    public Text countertext;

    void OnTriggerEnter2D(Collider2D other)
    {
        numbercount.value += creditvalue;
        countertext.text = numbercount.value.ToString();
        gameObject.SetActive(false);
    }

    public void Start()
    {
        countertext.text = numbercount.value.ToString();
    }
}
