using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;
    private Vector2 direction;
    public float forceside = 3f;
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * forceside;
        body.AddForce(direction, ForceMode2D.Force);
    }
}
