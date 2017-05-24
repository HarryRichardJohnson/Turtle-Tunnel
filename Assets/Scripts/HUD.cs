/*
This script holds variables and methods used for the HUD interactions in game.
*/

using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    //instance variables
    public Text distanceLabel, velocityLabel;
	public GameObject pauseCanvas,settingsCanvas;


    //This method sets the in game text labels for the distance traveled, and the current velocity.
    public void SetValues (float distanceTraveled, float velocity) {
		distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = ((int)(velocity * 10f)).ToString();
	}

	public void PauseGame(){

		Time.timeScale = 0;
		pauseCanvas.gameObject.SetActive (true);
	}

	public void PlayGame(){
		Time.timeScale = 1;
		pauseCanvas.gameObject.SetActive (false);
	}

	public void ChangeToMainMenu(){
		ChangeScene ch = new ChangeScene ();
		ch.changeScene ("Start Menu");
	}

	public void ChangetoSettings(){
		settingsCanvas.gameObject.SetActive (true);
		pauseCanvas.gameObject.SetActive (false);
	}

	public void ChangeToResume(){
		settingsCanvas.gameObject.SetActive (false);
		pauseCanvas.gameObject.SetActive (true);
	}

}