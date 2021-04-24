using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class SquareBehavior : MonoBehaviour
{
    [SerializeField] private GameObject square;
    
    public void ActivateObject()
    {
        square.SetActive(true);
    }

    public void DeactivateObject()
    {
        square.SetActive(false);
    }
    
}
