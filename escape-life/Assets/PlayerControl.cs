using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.mass++;
        }
        if(Input.GetMouseButtonDown(1))
        {
            rb.mass--;
        }

        if (Input.GetKeyDown("w"))
        {
            rb.AddForce()
        }
    }
}
