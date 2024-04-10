using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ToDo: This script requires the use of three components:
// Animator, Player, and Rigidbody2D
// Use the RequireComponent attribute to make sure the GameObject this script is attached to has these components.
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    // ToDo: This script needs a reference variable for each component:
    Rigidbody2D rigidbody;
    Player playerScript;
    Animator animatorComponent;

    public GameObject particlePrefab;

    void Start()
    {
        // ToDo: Get a reference to each component using GetComponent
        rigidbody = GetComponent<Rigidbody2D>();
        playerScript = GetComponent<Player>();
        animatorComponent = GetComponent<Animator>();
    }

    void Update()
    {
        // ToDo: Set the animator bool parameter "Falling" to the value of player.isFalling.
        //we use an instance of the player script, bc nothing on it is static. Then we access the isFalling property on that script here!
        animatorComponent.SetBool("Falling", playerScript.isFalling);

        // ToDo: Set the animator float parameter "YVelocity" to the value of rigidbody2D.velocity.y
        animatorComponent.SetFloat("YVelocity", rigidbody.velocity.y);
    }

    public void Smoke() //name of the method in the script must be exactly the same as the name from the animation event (hence the "function" word in the animation event)
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}