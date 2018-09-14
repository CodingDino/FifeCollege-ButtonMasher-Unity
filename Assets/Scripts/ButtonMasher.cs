using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click the button
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timerText; // display text for the timer remaining
    public float gameLength; // how many seconds will the game last
    public AudioSource gameOverSound; // sound that will play when we run out of time
    public TextMesh messageText; // display text of a message to the player
    public AudioSource startSound; // sound that will play when we press the button to start the game

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; // Numerical time remaining for the game
    private bool gameRunning = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");
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
            // Only do this if we just now hit gameover
            if (gameRunning == true)
            {
                // Play the game over sound
                gameOverSound.Play();

                // Show the player their score
                messageText.text = "Time up! Final Score = " + score.ToString();
            } // End of if (gameRunning == true)

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
        else
        {
            // game is not running and we click the button
            gameRunning = true;

            // Set the timer to the full length of our game
            timeRemaining = gameLength;

            // Tell the player how to play
            messageText.text = "Mash the button!";
            
            // Reset the score
            score = 0;

            // Update visual score
            scoreText.text = score.ToString();

            // Play start game sound
            startSound.Play();

        } // End of else (gameRunning == true)

    } // End of OnMouseDown()
    
} // End of ButtonMasher class

