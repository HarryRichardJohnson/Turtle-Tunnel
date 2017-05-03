using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class MainMenu : MonoBehaviour {

	public Player player;

	public Text scoreLabel;

    public Text coinLabel;

    private int score;

	private void Awake () {
		Application.targetFrameRate = 1000;
	}

    public void StartGame (int mode) {
        score = 0;
        player.StartGame(mode);
		gameObject.SetActive(false);
		Cursor.visible = false;
	}

    public void UpdateCoinScore(int value)
    {
        score += value;
    }

    public void EndGame (float distanceTraveled) {
		scoreLabel.text = "Total score: " + ((int)(distanceTraveled * 10f)).ToString();
        coinLabel.text = "Coins: " + score.ToString();
        gameObject.SetActive(true);
		Cursor.visible = true;
	}
}