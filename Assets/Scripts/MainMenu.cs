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

    public GameObject backgroundSoundObject;
    public AudioSource backgroundAudioSource;

    public GameObject waterSoundObject;
    public AudioSource waterAudioSource;

    //While awake, has an estimated frame rate of 1000
    private void Awake()
    {
        Application.targetFrameRate = 1000;
		Player.coinTotal = SaveLoad.load("Score");
		coinLabel.text = "Coins: " + Player.coinTotal.ToString();
        backgroundSoundObject = GameObject.Find("BackgroundSong");
        backgroundAudioSource = backgroundSoundObject.GetComponent<AudioSource>();

        waterSoundObject = GameObject.Find("WaterSound");
        waterAudioSource = waterSoundObject.GetComponent<AudioSource>();

		if(PlayerSound.isSoundOn == false)
        {
            backgroundAudioSource.mute = true;
            waterAudioSource.mute = true;
        }
    }

    //When start game is pressed
    public void StartGame(int mode)
    {
        waterAudioSource.Play();
        backgroundAudioSource.Play();
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
        backgroundAudioSource.Stop();
        waterAudioSource.Stop();
		Player.coinTotal += score;
        scoreLabel.text = "Total score: " + ((int)(distanceTraveled * 10f)).ToString();
		coinLabel.text = "Coins: " + Player.coinTotal.ToString();
        gameObject.SetActive(true);
        Cursor.visible = true;
		SaveLoad.save ("Score");
    }
}