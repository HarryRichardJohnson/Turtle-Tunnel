using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkin : MonoBehaviour 
{

	public GameObject[] turtleSkin;
	public GameObject currentSkin;
	public int skinUnlock;

	void Start(){
		checkSkinUnlock ();
	}

	private void checkSkinUnlock(){

		switch (skinUnlock) {
		case 0:
			currentSkin = turtleSkin [0];
			currentSkin.SetActive (true);
			//Instantiate (turtleSkin [0]);
			break;
		case 1: 
			currentSkin = turtleSkin [1];
			currentSkin.SetActive (true);
			break;
		default:
			currentSkin.SetActive (true);
			break;
		}
	}
}
