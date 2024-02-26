using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    public float spinX;
    public float spinY;
    public float spinZ;

    void Update()
    {
        transform.Rotate(spinX * Time.deltaTime, spinY * Time.deltaTime, spinZ * Time.deltaTime);
    }
}
