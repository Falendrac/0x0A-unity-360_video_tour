using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Permit to the user to rotate the camera when mouse click
/// </summary>
public class LookAround : MonoBehaviour
{
    // Speed of the camera
    float speed = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * -Input.GetAxis("Mouse Y"));
        }
    }
}
