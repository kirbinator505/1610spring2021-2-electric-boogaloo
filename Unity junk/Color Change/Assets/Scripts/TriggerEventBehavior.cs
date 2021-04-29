using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent Trigger;

    private void OnTriggerEnter(Collider other)
    {
        Trigger.Invoke();
    }
}
