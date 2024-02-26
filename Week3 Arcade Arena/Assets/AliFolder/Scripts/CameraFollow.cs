using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 

    void LateUpdate()
    {
        if (player != null)
        {
            
            Vector3 newPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.position = newPosition;
        }
    }
}
