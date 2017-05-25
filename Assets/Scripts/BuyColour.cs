using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyColour : MonoBehaviour {

	// Use this for initialization
	private void Awake () {
		SaveLoad coinTotal = GameObject.GetObject<SaveLoad>();
		int playerCoinTotal = coinTotal.load();
		TurtleCostIndex index = GameObject.GetObject<TurtleCostIndex>();
		int colourIndex = index.GetSpriteColour();
	}

	// Update is called once per frame
	void Update () {
		if()
	}
}
