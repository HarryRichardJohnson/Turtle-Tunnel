
using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour
{

	public static void save() 
	{
		PlayerPrefs.SetInt("Score", Player.coinTotal);
	}
	public static int load() 
	{
		return PlayerPrefs.GetInt("Score");
	}
}
