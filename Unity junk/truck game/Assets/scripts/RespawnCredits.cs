using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCredits : MonoBehaviour
{
    [SerializeField] private int timer;
    public GameObject lol;

    void Update()
    {
        timer++;
        if (timer == 500)
        {
            lol.SetActive(true);
            timer = 0;
        }
    }
}
