using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("PowerUp"))
        {
                print("Collected Power Up");
        }

        if (other.CompareTag("Ammo"))
        {
                print("Got Ammo");
        }

        if (other.CompareTag("Health"))
        {
                print(("Health"));
        }
    }
}
