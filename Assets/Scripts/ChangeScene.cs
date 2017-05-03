using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	public ChangeScene(){
	}

	public void changeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
