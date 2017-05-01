using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text distanceLabel, velocityLabel;
	public bool isPaused = false;

	public void SetValues (float distanceTraveled, float velocity) {
		distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = ((int)(velocity * 10f)).ToString();
	}

	public void PauseGame(){
		if (isPaused == false) {
			Time.timeScale = 0;
			isPaused = true;
		} else {
			Time.timeScale = 1;
			isPaused = false;
		}
	}
}