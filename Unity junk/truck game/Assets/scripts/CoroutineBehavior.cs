using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent start;
    public int num, max;
    public float hold;
    private WaitForSeconds time;

    IEnumerator Start()
    {
        time = new WaitForSeconds(hold);
        while (num < max)
        {
            start.Invoke();
            yield return time;
        }
    }
}
