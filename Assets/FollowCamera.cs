using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    /* Nest camera inside your character
     * target is your playable character you want to follow
     * Select your character inside Unity
     */
    public GameObject target;

    private float leftCamera = -2f;
    private float rightCamera = 2f;
    private float currentLocation;
    public float cameraSpeed = 2f;

    void Start()
    {
        currentLocation = transform.localPosition.x; 
    }

    void Update()
    {
        currentLocation += Input.GetAxis("Horizontal") * cameraSpeed;
        Debug.Log(currentLocation);

        if (currentLocation < leftCamera)
        {
            currentLocation = leftCamera;
        }
        if (currentLocation > rightCamera)
        {
            currentLocation = rightCamera;
        }

        transform.localPosition = new Vector3(currentLocation, transform.localPosition.y, transform.localPosition.z);
    }
}
