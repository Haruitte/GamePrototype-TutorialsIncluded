using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform CamRotator;
    public float sensitivity = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") == 1)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
