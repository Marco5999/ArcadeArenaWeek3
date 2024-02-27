using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public List<Transform> points;
    public int currentPoint;

    public float speed;
    private float movement;

    void FixedUpdate()
    {
        movement = speed * Time.fixedDeltaTime;
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, movement);

        if (transform.position == points[currentPoint].position)
        {
            if (currentPoint == points.Count - 1)
            {
                currentPoint = 0;
            } else {
                currentPoint += 1;
            }
        }
    }
}
