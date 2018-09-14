using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click the button
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timerText; // display text for the timer remaining
    public float gameLength; // how many seconds will the game last

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; // Numerical time remaining for the game
    private bool gameRunning = true;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength;
	} // End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");

        // Update the numerical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;

        // Update the visual time remaining
        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        // Check if we have run out of time
        if (timeRemaining <= 0)
        {
            // Stop the game running
            gameRunning = false;

            // Stop our time from going negative
            timeRemaining = 0;
        } // End of if (timeRunning <= 0)

    } // End of Update()

    // Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        // Check if the game is still running....
        if (gameRunning == true)
        {
            // Trigger our clicking sound to play
            clickSound.Play();
            // Increase the score by 1
            score = score + 1;
            // Update visual score
            scoreText.text = score.ToString();
        } // End of if (gameRunning == true)

    } // End of OnMouseDown()
    
} // End of ButtonMasher class

