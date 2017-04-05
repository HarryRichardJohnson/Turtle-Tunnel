using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {
	public GameObject audioSource;
	bool soundToggle  = true;
	// Use this for initialization

	public void OnGui(){
		soundToggle = !soundToggle;
		if(soundToggle)
		{
			AudioListener.pause = true;
			//audioSource.mute = true;
			//audioSource.volume = 1.0f;
		}
		else
		{
			AudioListener.pause = false;
			//audioSource.mute = false;
			//audioSource.volume = 0.0f;
	}

	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
