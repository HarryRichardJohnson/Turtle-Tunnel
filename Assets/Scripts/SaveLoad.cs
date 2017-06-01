
using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour
{

	public static void save(string pref) 
	{
		PlayerPrefs.SetInt(pref, Player.coinTotal);
	}
	public static int load(string pref) 
	{
		return PlayerPrefs.GetInt(pref);
	}
}
