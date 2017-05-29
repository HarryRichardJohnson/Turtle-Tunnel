using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSound : MonoBehaviour {

    public Toggle myToggle;

    public static bool isSoundOn; 

	void Awake()
	{
		DontDestroyOnLoad (myToggle);
	}
    public void start()
    {
        isSoundOn = myToggle.isOn;

    }

	void Update()
	{
		toggleSound ();
		previousState ();
		//PlayerPrefs.GetInt ("SoundOn");	
	}

    public void toggleSound()
    {
			
		if(myToggle.isOn)
        {
			PlayerPrefs.SetInt ("SoundOn", 1);
            isSoundOn = true;
            print("Sound is on");
        }
        else
        {
			PlayerPrefs.SetInt ("SoundOn", 0);
            isSoundOn = false;
            print("Sound is off");
        }
    }

	void  previousState()
	{
		if (PlayerPrefs.GetInt ("SoundOn").Equals (1)) {
			myToggle.isOn = true;
		} 
		else 
		{
			myToggle.isOn = false;
		}
	}
}
