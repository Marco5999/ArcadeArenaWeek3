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

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PositionA")
        {
            Debug.Log("Changing to B");
            movingToA = false;
            movingToB = true;
        }

        if (other.gameObject.tag == "PositionB")
        {
            Debug.Log("Changing to A");
            movingToA = true;
            movingToB = false;
        }
    }
}
