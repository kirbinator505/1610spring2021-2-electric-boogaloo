using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyReset : MonoBehaviour
{
    public BoolData key;

    void Start()
    {
        key.value = false;
    }
}
