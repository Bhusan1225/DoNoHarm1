using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{

    public float rotationSpeed = 100f; // Speed at which the lever rotates
    public float minRotation = 0f;    // Minimum angle (0 degrees)
    public float maxRotation = 180f; // Maximum angle (180 degrees)

    private float currentRotation = 0f; // Current rotation of the lever

    void Update()
    {
        // Get horizontal mouse movement
        float mouseX = Input.GetAxis("Mouse X");

        // Calculate the new rotation based on mouse movement
        currentRotation += -mouseX * rotationSpeed * Time.deltaTime;

        // Clamp the rotation between minRotation and maxRotation
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        // Apply the rotation to the lever
        transform.localRotation = Quaternion.Euler(0f, 0f, currentRotation);
    }
}

