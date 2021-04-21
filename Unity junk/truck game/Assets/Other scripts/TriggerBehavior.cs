using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent trigger;

    private void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }
}
