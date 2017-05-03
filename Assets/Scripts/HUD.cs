using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class HUD : MonoBehaviour {

	public Text distanceLabel, velocityLabel;
	public bool isPaused = false;
	public Button pauseButton;



	public void SetValues (float distanceTraveled, float velocity) {
		distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = ((int)(velocity * 10f)).ToString();
	}

	public void PauseGame(){
		
		pauseButton.onClick.AddListener (ButtonClicked);

		if (isPaused == false) {
			Time.timeScale = 0;
			isPaused = true;
		

		} else {
			Time.timeScale = 1;
			isPaused = false;
		
		}
	}

	void ButtonClicked(){
		Debug.Log("Pause Button Clicked");
	}
}