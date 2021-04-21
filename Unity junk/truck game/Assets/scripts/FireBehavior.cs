using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
