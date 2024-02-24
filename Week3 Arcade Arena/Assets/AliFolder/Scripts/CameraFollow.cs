using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player GameObject

    void LateUpdate()
    {
        if (player != null)
        {
            // Set the camera's position to match the player's position, but keep the same camera height
            Vector3 newPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.position = newPosition;
        }
    }
}
