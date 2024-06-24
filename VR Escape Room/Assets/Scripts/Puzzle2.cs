using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE: add to book object

public class Puzzle2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerExit(Collider collision)
    {
        Debug.Log("Book exited shelf");
        if (collision.gameObject.name == "Shelf_04_snaps001 (1)")
        {
            //GameObject vrtk_parent1 = transform.parent.gameObject;
            //transform.parent.GetComponent<P2Controller>().CollisionDetected(this);
            //GameObject vrtk_parent2 = vrtk_parent1.transform.parent.gameObject;
            //GameObject puzzle_control = vrtk_parent2.transform.parent.gameObject;
            //puzzle_control.GetComponent<P2Controller>().CollisionDetected(this);
            P2Controller script = this.GetComponentInParent<P2Controller>();
            script.CollisionDetected(this);
        }
    }
}
