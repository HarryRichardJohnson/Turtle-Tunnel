using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonRight : MonoBehaviour {

	void Update()
	{
		if (turtleColour.turtleSprite.Length >= BuyColour.getTurtleIndex)
			gameObject.SetActive (true);
		else
			gameObject.SetActive (false);
	}

	void onClick()
	{
			BuyColour.getRightButtonIndex;
	}
		
}
