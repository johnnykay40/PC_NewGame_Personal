using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 80f;

    [SerializeField] private Transform playerBody;

    [SerializeField] float xRotation = 0;


    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation += mouseY;
        
        playerBody.Rotate(Vector3.up * mouseX);
    }
}


