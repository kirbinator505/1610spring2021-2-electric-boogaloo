using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUp : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    private Vector2 direction;
    private Vector2 ydirection;
    public float forceup = 0.2f;
    public float forceside = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * forceside;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
    }
}
