using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Controller : MonoBehaviour
{
    public GameObject hint;
    public Material complete;

    public void CollisionDetected(Puzzle2 childScript)
    {
        Debug.Log("Puzzle 2 signal received");
        hint.GetComponent<Renderer>().material = complete;
        transform.parent.GetComponent<AllPuzzlesController>().Puzzle2Complete(this);
    } 
}
