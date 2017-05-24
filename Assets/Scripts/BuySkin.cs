using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySkin : MonoBehaviour {

	public void perchaseSkin(int skin){
		//Checks if player can afford the perchase
		if (Player.coinTotal>50*skin) {
			//this records that the player owns this skin. 1 represents true, 0 represents false 
			//this is a simple way to get around PlayerPrefs not alloqing a boolean
			PlayerPrefs.SetInt ("skin:"+skin, 1);
			//Player coins are subtracted for payment
			Player.coinTotal = Player.coinTotal - 50*skin;
			equipSkin.EquipSkin (skin);
		}
	}
}
