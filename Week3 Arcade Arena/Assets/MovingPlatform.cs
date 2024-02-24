using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public float movement;

    public GameObject PositionA;
    public GameObject PositionB;
    public bool movingToA = true;
    public bool movingToB;

    void Start()
    {
        PositionA = GameObject.FindGameObjectWithTag("PositionA");
        PositionB = GameObject.FindGameObjectWithTag("PositionB");
    }

    void FixedUpdate()
    {
        movement = speed * Time.fixedDeltaTime;

        if (movingToA)
        {
            transform.position = Vector3.MoveTowards(transform.position, PositionA.transform.position, movement);
        }

        if (movingToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, PositionB.transform.position, movement);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PositionA")
        {
            movingToA = false;
            movingToB = true;
        }

        if (other.gameObject.tag == "PositionB")
        {
            movingToA = true;
            movingToB = false;
        }
    }
}
