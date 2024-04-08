using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //public float variable to control how fast the obstacle moves across the screen
    public float moveSpeed = 4.0f;
    //public float variable to control how far the object should go before being destroyed offscreen.
    public float travelDistance = -10.75f;

    void Start()
    {

    }

    void Update()
    {
        //Move the obstacle to the left at a constant rate. 
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        //If the obstalce is off screen to the left, destroy this GameObject
        if (transform.position.x <= travelDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTarget(other.gameObject, 1);
    }
}
