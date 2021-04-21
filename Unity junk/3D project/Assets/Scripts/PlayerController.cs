using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private float horsePower = 0;
    [SerializeField] private float RPM;
    private const float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshProUGUI spedometerText;
    [SerializeField] private TextMeshProUGUI RPMText;
    [SerializeField] private List<WheelCollider> wheels;
    [SerializeField] private int wheelsOnGround;

        void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

  void Update()
  {
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");
      if (IsOnGround())
      {
          playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
          //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

          transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

          speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
          spedometerText.SetText(" " + speed + "mph");

          RPM = (speed % 30) * 40;
          RPMText.SetText("RPM: " + RPM);
      }
  }

  bool IsOnGround()
  {
      wheelsOnGround = 0;
      foreach (WheelCollider wheel in wheels)
      {
          if (wheel.isGrounded)
          {
              wheelsOnGround++;
          }
      }

      if (wheelsOnGround == 4)
      {
          return true;
      }
      else
      {
          return false;
      }
  }
}