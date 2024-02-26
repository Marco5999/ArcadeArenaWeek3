using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMaze : MonoBehaviour
{
    public float speed = 5f; 
    public float mouseSensitivity = 100f; 

    float verticalMovement;
    float horizontalMovement;
    float mouseX;
    float mouseY;

    float xRotation = 0f;

    void Update()
    {
        
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");

        
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        
        transform.Rotate(Vector3.up * mouseX);

        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        
        Vector3 moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
        moveDirection.y = 0f; 
        moveDirection.Normalize(); 
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
