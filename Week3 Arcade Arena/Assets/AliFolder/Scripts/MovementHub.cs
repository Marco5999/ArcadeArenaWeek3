using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHub : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Get input for horizontal and vertical movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Apply movement
        transform.Translate(movement);
    }
}
