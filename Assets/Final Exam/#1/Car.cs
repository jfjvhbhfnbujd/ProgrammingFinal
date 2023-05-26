using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float verticalInput;
    private float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }

   
    void Update()
    {
        
        /*
         * FINAL EXAM #1
         * Write a script that will allow movement.
         * The Vertical Axis should make the player move forwards and backwards
         * The Horizontal Axis should make the player rotate on the Vector3.back axis
         */
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.back);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetAxis("Vertical") > 0) 
        {
            transform.Translate(Vector2.up * 1 * Time.deltaTime * moveSpeed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector2.down * 1 * Time.deltaTime * moveSpeed);
        }
    }
}
