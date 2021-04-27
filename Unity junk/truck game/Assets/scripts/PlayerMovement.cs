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

    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpForce = 300f;
    [SerializeField] private int jumpCountMax = 2;
    private int jumpCount;

    private void Awake()
    {
        ballRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        jumpCount = 0;
    }

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      
        if(!Input.GetButtonDown("Jump") || jumpCount >= jumpCountMax) return;
        direction.y = jumpForce;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Impulse);
        jumpCount++;
    }

    public void SetRBDynamic()
    {
        ballRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
    }
}
