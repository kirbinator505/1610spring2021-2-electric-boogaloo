using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehavior : MonoBehaviour
{
    public int number, total;
    public string[] cars;
    public Weapon[] weapons;
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            total = i;
            print(total);
        }

        foreach (var car in cars)
        {
            print("I have a " + car);
        }

        foreach (var Weapon in weapons)
        {
            print("you have my " + Weapon.name + ", with a value of " + Weapon.power);
        }

    }
}
