/*
This script holds a method for changing the screen/game state.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public Animator playAnimator, shopAnimator, settingsAnimator, instructionsAnimator, titleAnimator;


    public void changeScene(string sceneName)
    {
		SceneManager.LoadScene (sceneName);

    }

	void ExitAnimation()
	{
		playAnimator.Play ("playClick");
		instructionsAnimator.Play ("instructionsClick");
		shopAnimator.Play ("shopClick");
		settingsAnimator.Play ("settingsClick");
		titleAnimator.Play ("ttunnelText");
	}

	public void changeSceneToPlay ()
	{
		ExitAnimation ();
		StartCoroutine(WaitForPlay ());
	}


	public void changeSceneToShop()
	{
		ExitAnimation ();
		StartCoroutine(WaitForShop ());
	}

	public void changeSceneToSettings()
	{
		ExitAnimation ();
		StartCoroutine (WaitForSettings ());
	}
		
	public void changeSceneToInstructions()
	{
		ExitAnimation ();
		StartCoroutine (WaitForInstructions ());
	}

	IEnumerator WaitForPlay(){
		yield return new WaitForSeconds (01f);
		SceneManager.LoadScene ("Game");
	}

	IEnumerator WaitForShop(){
		yield return new WaitForSeconds (01f);
		SceneManager.LoadScene ("Shop");
	}

	IEnumerator WaitForInstructions(){
		yield return new WaitForSeconds (01f);
		SceneManager.LoadScene ("Instructions");
	}

	IEnumerator WaitForSettings(){
		yield return new WaitForSeconds (01f);
		SceneManager.LoadScene ("SettingsMenu");
	}
}