using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhaustScript : MonoBehaviour
{
    public float timeToDestry = 1f;

    private float startTime;
    private SpriteRenderer sr;

    private void Awake()
    {
        startTime = Time.time;
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startTime) > timeToDestry)
        {
            Destroy(this.gameObject);
        }
        transform.localScale += Vector3.one*Time.deltaTime*0.5f/timeToDestry;
        sr.color -= new Color(0,0,0,Time.deltaTime / timeToDestry);
    }
}
