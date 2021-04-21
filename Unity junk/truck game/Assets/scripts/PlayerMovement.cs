using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D ballRigidbody2D;
    private Vector2 direction;
    private Vector2 ydirection;

    public float speed = 3f;

    public float jumpForce = 300f;

    public int jumpcountmax = 2;
    
    private int jumpcount;

    void Start()
    {
        ballRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        jumpcount = 0;
    }

    void Update()
    {
    direction.x = Input.GetAxis("Horizontal") * speed;
    ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      
      if (Input.GetButtonDown("Jump") && jumpcount < jumpcountmax)
      {
          ydirection.y = jumpForce;
          ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
          jumpcount++;
      }
    }
}
