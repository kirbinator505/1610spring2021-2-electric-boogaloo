using System;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    public Color animalColor = Color.red;
    public float speed = 1.0f;
    public string animalName = "Gerald";
    public int health = 10;

    private void Start()
    {
        Debug.Log("hello world");
    }
}