using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControls : MonoBehaviour {
    public Camera camera;
    public float lookSenitivity = 5;
    public float lookSmoothDamp = 0.1f;
    public float xRotation;
    public float yRotation;
    public float xRotationV;
    public float yRotationV;
    public float currentXRotation;
    public float currentYRotation;

    private float maxY = 9.614f;
    private float maxX = 11f;
    [HideInInspector]
    public float H;
    [HideInInspector]
    public float V;


    public void Update()
    {/*
        H = Input.GetAxis("Horizontal_joy");
        V = Input.GetAxis("Vertical_joy");
        if (H == 0 && V == H)
        {
            camera.transform.rotation = Quaternion.identity;
        }
        else
        {

            xRotation = V * lookSenitivity;
            yRotation = H * lookSenitivity;

            yRotation = Mathf.Clamp(yRotation, -maxY, maxY);
            xRotation = Mathf.Clamp(xRotation, -maxX, maxX);

            currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationV, lookSmoothDamp);
            currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationV, lookSmoothDamp);

            camera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }*/
    }
}
