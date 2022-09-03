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

        if (Input.GetKeyDown("w"))
        {
            rb.velocity = new Vector2(0,velocityScaler);
        }
        if (Input.GetKeyDown("s"))
        {
            rb.velocity = new Vector2(0,-velocityScaler);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = new Vector2(-velocityScaler, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector2(velocityScaler, 0);
        }
        if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
