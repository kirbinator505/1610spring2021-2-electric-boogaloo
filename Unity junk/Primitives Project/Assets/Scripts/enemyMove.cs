using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody objectRB;
    public float bottomBound = -15f;
    
    // Start is called before the first frame update
    void Start()
    {
        objectRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRB.AddForce(Vector3.forward * - speed);

        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
