using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  private bool jumpKeyWasPressed;
  private float horizontalInput;
  private float verticalInput;
  private Rigidbody rigidbodyComponent;
  private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
      rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Key pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
          jumpKeyWasPressed = true;
        }
        // access horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");

    }

    // FixedUpdate is called once every physics update
    private void FixedUpdate()
    {
      // Key pressed down
      if (jumpKeyWasPressed == true)
      {
        // Player comes back down
        GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        jumpKeyWasPressed = false;
      }
      // Player moves left and right with A/D keys
      GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);

    }
}
