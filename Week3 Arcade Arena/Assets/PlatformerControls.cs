using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerControls : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public Rigidbody rigidBody;
    public float speed;
    public float jumpSpeed;
    public float fallSpeed;
    public bool onGround;

    private GameObject player;
    private GameObject startingPoint;
    public GameObject WinScreen;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        onGround = true;

        player = GameObject.FindGameObjectWithTag("Player");
        startingPoint = GameObject.FindGameObjectWithTag("RespawnPoint");
    }

    void Update()
    {
        HorizontalMovement();
        VerticalMovement();
        Jump();
    }

    void HorizontalMovement()
    {
        horizontal = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector3(speed * horizontal, rigidBody.velocity.y, rigidBody.velocity.z);
    }

    void VerticalMovement()
    {
        vertical = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, speed * vertical);
    }

    void Jump()
    {
        if(Input.GetKeyDown("g") && onGround)
        {
            onGround = false;
            rigidBody.AddForce(Vector3.up * jumpSpeed * 100f);
        }

        if(rigidBody.velocity.y < 0)
        {
            rigidBody.velocity += Vector3.up * Physics.gravity.y * (fallSpeed - 1) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }

        if (collision.gameObject.tag == "Death")
        {
            player.transform.position = startingPoint.transform.position;
        }

        if (collision.gameObject.tag == "Goal")
        {
            WinScreen.SetActive(true);
        }
    }
}
