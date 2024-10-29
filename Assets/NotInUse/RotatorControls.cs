using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorControls : MonoBehaviour
{
    [SerializeField] Transform rotatePivot;
    [SerializeField] private float yaw;
    [SerializeField] private float pitch;
    [SerializeField] private float speedH;
    [SerializeField] private float speedV;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -50, 60);

        rotatePivot.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}