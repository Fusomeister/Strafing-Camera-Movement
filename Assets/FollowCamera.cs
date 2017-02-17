using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public GameObject target;
    //Vector3 offset;

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

    void LateUpdate()
    {
        //float desiredAngle = target.transform.eulerAngles.y;
        //Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        //transform.position = target.transform.position - (rotation * offset);
        //transform.LookAt(target.transform);
    }
}
