/*
This script holds variables and methods dealing with the main menu and user interactions
with the buttons.
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class MainMenu : MonoBehaviour
{

    //Instance variables
	public Player player = new Player();
    public Text scoreLabel;
    public Text coinLabel;
    private int score;

    //While awake, has an estimated frame rate of 1000
    private void Awake()
    {
		Application.targetFrameRate = 1000;
		Player.coinTotal = SaveLoad.load();
		coinLabel.text = "Coins: " + Player.coinTotal.ToString();
	
    }

    //When start game is pressed
    public void StartGame(int mode)
    {
        score = 0;
        player.StartGame(mode);
        gameObject.SetActive(false);
        Cursor.visible = false;
    }

    //Updates the coin score in game as the player collects them
    public void UpdateCoinScore(int value)
    {
        score += value;
    }

    //Shows the distance travelled, and the total coins collected when game has ended.
    public void EndGame(float distanceTraveled)
    {
        scoreLabel.text = "Total score: " + ((int)(distanceTraveled * 10f)).ToString();
		Player.coinTotal += score;
		UpdateCoin ();
		SaveLoad.save ();
        gameObject.SetActive(true);
        Cursor.visible = true;
    }
	public void UpdateCoin()
	{
		coinLabel.text = "Coins: " + Player.coinTotal.ToString();
	}
}