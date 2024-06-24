using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AllPuzzlesController : MonoBehaviour
{
    // Puzzle Facillitating Objects
    public GameObject door;
    //public Text winMessage;
    public TMP_Text winMessage;

    // Puzzle Tracking
    public bool p1complete;
    public bool p2complete;
    public bool p3complete;
    public bool doorOpened;

    // Helper Functions
    public void Puzzle1Complete(P1Controller childScript)
    {
        Debug.Log("Puzzle 1 Complete!");
        this.p1complete = true;
    } 

    public void Puzzle2Complete(P2Controller childScript)
    {
        Debug.Log("Puzzle 2 Complete!");
        this.p2complete = true;
    } 

    public void Puzzle3Complete(P3Controller childScript)
    {
        Debug.Log("Puzzle 3 Complete!");
        this.p3complete = true;
    } 

    public void DoorUnlocked(DoorController childScript) {
        if(p1complete && p2complete && p3complete) {
            Debug.Log("Door is open!");
            this.doorOpened = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Init all puzzle booleans to false
        this.p1complete = false;
        this.p2complete = false;
        this.p3complete = false;
        this.doorOpened = false;
        // winMessage.GetComponent<MeshRenderer>().enabled = false;
        // winMessage.text = "";
        winMessage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(doorOpened) {
            // Do completion sequence!
            door.GetComponent<MeshRenderer>().enabled = false;
            // winMessage.GetComponent<MeshRenderer>().enabled = true;
            // winMessage.text = "Congratulations, you escaped!";
            winMessage.gameObject.SetActive(true);
            // // TODO: see how suddenly this ends
            Time.timeScale = 0;
            //Application.Quit();
        }
    }
}
