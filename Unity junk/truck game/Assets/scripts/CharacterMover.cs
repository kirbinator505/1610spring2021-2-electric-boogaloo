using System.Timers;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, gravity = -8f, jumpForce = 10f;
    public int jumpCountMax = 2;

    private float yDirection;
    private int jumpCount;
    private CharacterController controller;
    private Vector3 movement, rotation;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.Set(speed*Input.GetAxis("Vertical"), yDirection, 0);
        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yDirection = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            yDirection = jumpForce;
            jumpCount++;
        }

        rotation.y = Input.GetAxis("Horizontal");
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
