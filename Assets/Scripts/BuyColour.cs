using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyColour : MonoBehaviour {

	private int turtleIndex;

	// Use this for initialization
	private void Awake () {

		turtleIndex = 0;
		int playerCoin = SaveLoad.load ();
	}

	public void getRightButtonIndex()
	{
		turtleIndex++;
	}

	public void getLeftButtonIndex()
	{
		turtleIndex--;
	}

	public int getTurtleIndex()
	{
		return turtleIndex;
	}
}
