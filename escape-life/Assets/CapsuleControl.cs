using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleControl : MonoBehaviour
{
    public float thrustScalar = 1f;
    public float exhaustScaler = 1f;
    public float exhaustRandomScaler = 0.1f;
    public GameObject exhaust;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            FireEngine(Vector2.up);
        }
        if (Input.GetKey("s"))
        {
            FireEngine(Vector2.down);
        }
        if (Input.GetKey("a"))
        {
            FireEngine(Vector2.left);
        }
        if (Input.GetKey("d"))
        {
            FireEngine(Vector2.right);
        }
    }

    void FireEngine(Vector2 vec)
    {
        rb.AddForce(thrustScalar * vec);
        GameObject gas = Instantiate(exhaust, transform.position, Quaternion.identity);
        gas.GetComponent<Rigidbody2D>().velocity = rb.velocity -(vec+ new Vector2(Random.value, Random.value)*exhaustRandomScaler) * exhaustScaler;
    }
}
