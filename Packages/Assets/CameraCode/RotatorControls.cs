using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorControls : MonoBehaviour
{
    // Start is called before the first frame update
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
        DetectMouse();
        ApplyCameraRotation();
    }

    private void DetectMouse()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y"); 
        pitch = Mathf.Clamp(pitch, - 50, 60);

    }

    private void ApplyCameraRotation()
    {
        rotatePivot.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

}
