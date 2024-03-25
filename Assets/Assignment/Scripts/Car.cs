using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    protected float acceleration;
    protected float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rb;
    float maxSpeed = 500;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        playerControls();
    }
    private void FixedUpdate()
    {
        rb.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if(rb.velocity.magnitude < maxSpeed) // Max Speed
        {
            rb.AddForce(force);
        }

    }

    protected virtual void playerControls()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
}
