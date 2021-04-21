using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalinput;
    public float sped = 10.0f;
    public float boundary = 20.0f;
    public GameObject projectileprefabs;
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * sped);
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown((KeyCode.Space)))
        {
            Instantiate(projectileprefabs, transform.position, projectileprefabs.transform.rotation);
        }
    }
}
