using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;
    public float force = 1.0f;
    private Vector2 direction;

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * force;
        body.AddForce(direction, ForceMode2D.Force);
    }
}
