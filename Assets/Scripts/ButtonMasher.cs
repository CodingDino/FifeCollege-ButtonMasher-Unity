using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click the button

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");
	} // End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");
    } // End of Update()

    // Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        // Trigger our clicking sound to play
        clickSound.Play();
    } // End of OnMouseDown()


} // End of ButtonMasher class

