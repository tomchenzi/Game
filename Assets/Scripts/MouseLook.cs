using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float MouseMoveSpeed;
    private Transform CameraTransform;
    private Vector3 CameraRoation;
    public Vector2 MaxMinAngle;
    void Start()
    {
        CameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float tmp_X = Input.GetAxis("Mouse X");
        float tmp_Y = Input.GetAxis("Mouse Y");
        CameraRoation.x -= tmp_Y * MouseMoveSpeed;
        CameraRoation.y += tmp_X * MouseMoveSpeed;
        CameraRoation.x = Mathf.Clamp(CameraRoation.x,MaxMinAngle.x,MaxMinAngle.y);
        CameraTransform.rotation = Quaternion.Euler(CameraRoation.x, CameraRoation.y,0);
    }
}
