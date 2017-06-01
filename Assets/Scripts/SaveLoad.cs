
using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour
{

	public static void save(string pref, int number) 
	{
		PlayerPrefs.SetInt(pref, number);
	}
	public static int load(string pref) 
	{
		return PlayerPrefs.GetInt(pref);
	}
}
