using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocityScaler = 1;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector2(0,velocityScaler));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector2(0,-velocityScaler));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-velocityScaler, 0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(velocityScaler, 0));
        }
        // if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        // {
        //     rb.AddForce(ector2.zero;
        // }
    }
}
