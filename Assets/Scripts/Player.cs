using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float jumpForce = 300f;
    public bool isFalling = true;

   void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
              {
                  rigidbody.AddForce(Vector3.up * jumpForce);
              }
        }  
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }
}