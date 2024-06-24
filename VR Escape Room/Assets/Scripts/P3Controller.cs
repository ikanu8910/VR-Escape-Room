using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Controller : MonoBehaviour
{
    public GameObject hint;

    public void CollisionDetected(sphereCollider childScript)
    {
        transform.parent.GetComponent<AllPuzzlesController>().Puzzle3Complete(this);
    } 
}
