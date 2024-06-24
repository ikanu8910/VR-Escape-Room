using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE: apply this script to HTile

public class Puzzle1 : MonoBehaviour
{
    void Start(){}

    //Detect collisions between the GameObjects with Colliders attached
    // void OnCollisionEnter(Collision collision)
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "tileLocation")
        {
            // Set the object's location and fix it
            this.gameObject.transform.position = new Vector3(
                collision.gameObject.transform.position.x,
                collision.gameObject.transform.position.y, 
                collision.gameObject.transform.position.z
            );
            //transform.parent.GetComponent<P1Controller>().CollisionDetected(this);
            P1Controller script = this.GetComponentInParent<P1Controller>();
            script.CollisionDetected(this);
        }
    }
}
