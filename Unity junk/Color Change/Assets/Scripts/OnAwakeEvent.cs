using UnityEngine;
using UnityEngine.Events;

public class OnAwakeEvent : MonoBehaviour
{
    public UnityEvent trigger;

    void Awake()
    {
        trigger.Invoke();
    }
}
