using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controller : MonoBehaviour
{
    public GameObject hint;
    public Material complete;

    public void CollisionDetected(Puzzle1 childScript)
    {
        hint.GetComponent<Renderer>().material = complete;
        transform.parent.GetComponent<AllPuzzlesController>().Puzzle1Complete(this);
    } 
}
