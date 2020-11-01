using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    private float movespeed = 5.0f;

    Vector2 movement;

    string buttonPressed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }


    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement *movespeed *Time.fixedDeltaTime);
    }

}
