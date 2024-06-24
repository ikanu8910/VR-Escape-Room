using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public float timeRemainingSecs = 10;
    public bool timerActive = true;
    //public Text timeText;
    public TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            if (timeRemainingSecs > 0 && timerActive)
            {
                timeRemainingSecs -= Time.deltaTime;
                DisplayTime(timeRemainingSecs);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeText.color = Color.red;
                timeText.text = "Time has run out!";
                timerActive = false;
                timeRemainingSecs = 0;
            }
        }
        else {
            // End the game
            Time.timeScale = 0;
            //Application.Quit();
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; // When less than one second remaining, show 1s
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
