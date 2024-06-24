using UnityEngine;
using System.Collections;

public class sphereCollider : MonoBehaviour
{
    public Material small;
    public Material large;
    void Start(){}

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "magnifying")
        {
            this.gameObject.GetComponent<Renderer>().material = large;
            transform.parent.GetComponent<P3Controller>().CollisionDetected(this);
        }
    }
}
