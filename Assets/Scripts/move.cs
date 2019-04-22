using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;  // Variable that determines the sideways force



    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }


    /*
    public Vector2 move;
    public Vector2 velocity; // in metres per second
    public float maxSpeed = 5.0f; // in metres per second
    public float acceleration = 5.0f; // in metres/second/second
    public float brake = 5.0f; // in metres/second/second
    public float turnSpeed = 30.0f; // in degrees/second
    private float speed = 0.0f;    // in metres/second
       */                            // Update is called once per frame
    void Update()

    {

        /*
        // the horizontal axis controls the turn
        float turn = Input.GetAxis("Horizontal");
        // turn the car
        transform.Rotate(0, 0, turn * turnSpeed * Time.deltaTime);
        // the vertical axis controls acceleration fwd/back
        float forwards = Input.GetAxis("Vertical");
        if (forwards > 0)
        {
            // accelerate forwards
            speed = speed + acceleration * Time.deltaTime;
        }
        else if (forwards < 0)
        {
            // accelerate backwards
            speed = speed - acceleration * Time.deltaTime;
        }
        else
        {
            // braking
            if (speed > 0)
            {
                speed = speed - brake * Time.deltaTime;
            }
            else
            {
                speed = speed + brake * Time.deltaTime;
            }
        }

        // clamp the speed
        speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
        // compute a vector in the up direction of length speed
        Vector2 velocity = Vector2.up * speed;
        // move the object
        transform.Translate(velocity * Time.deltaTime, Space.Self);
        */
    }




}
