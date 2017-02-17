using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour {

    private float turnSpeed = 10f;
    private float moveSpeed = 10f;
    private float mouseTurnMultiplier = 1;

    private float x;
    private float z;

    void Update()
    {
        // x is used for the x axis.  set it to zero so it doesn't automatically rotate
        x = 0;

        // check to see if the W or S key is being pressed.  
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Move the character forwards or backwards
        transform.Translate(0, 0, z);

        // Check to see if the A or D key are being pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            // Get the A or S key (-1 or 1)
            x = Input.GetAxis("Horizontal");
        }

        transform.Translate(x, 0, 0);

        //// Check to see if the right mouse button is pressed
        //if (Input.GetMouseButton(1))
        //{
        //    // Get the difference in horizontal mouse movement
        //    x = Input.GetAxis("Mouse X") * turnSpeed * mouseTurnMultiplier;
        //}

        //// rotate the character based on the x value
        //transform.Rotate(0, x, 0);
    }
}
