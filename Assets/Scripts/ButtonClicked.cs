using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicked : MonoBehaviour {

	// Use this for initialization
	public Animator animator;
	public UnityEngine.UI.Button playButton;
	ChangeScene ch = new ChangeScene();

	public void Start(){
		//playButton = GameObject.Find ("Play").GetComponent<UnityEngine.UI.Button> ();

		playButton.onClick.AddListener (SetBool);
	}

		void SetBool(){
			SetBoolWait ();
			//animator.Play ("playClick");

		}

	IEnumerator SetBoolWait(){
		yield return new WaitForSeconds (5);
		animator.Play ("playClick");
		Debug.Log ("LOL");	
		ch.changeScene ("Game");
	}
}
