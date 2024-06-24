using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        // Make door disappear
        transform.parent.GetComponent<AllPuzzlesController>().DoorUnlocked(this);
    }
}
