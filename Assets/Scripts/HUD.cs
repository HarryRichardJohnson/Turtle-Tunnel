/*
This script holds variables and methods used for the HUD interactions in game.
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class HUD : MonoBehaviour {

    //instance variables
	public Text distanceLabel, velocityLabel;
	public bool isPaused = false;
	public Button pauseButton;

    //This method sets the in game text labels for the distance traveled, and the current velocity.
	public void SetValues (float distanceTraveled, float velocity) {
		distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = ((int)(velocity * 10f)).ToString();
	}

    //This method pauses the game when the pause button is clicked.
	public void PauseGame(){
		
		pauseButton.onClick.AddListener (ButtonClicked);

        //Pause the game
		if (isPaused == false) {
			Time.timeScale = 0;
			isPaused = true;
		
        //If paused, unpause the game
		} else {
			Time.timeScale = 1;
			isPaused = false;
		
		}
	}

    //debugging method used to check if clicks work
	void ButtonClicked(){
		Debug.Log("Pause Button Clicked");
	}
}