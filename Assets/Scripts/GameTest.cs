using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTest{

	public MainMenu menu = new MainMenu();
	
	public void startGame(){
		menu.StartGame(1);
	}

	public bool speedIncreased(){
		if(menu.player.acceleration != 0){
			return true;
		}else{
			return false;
		}
	}

	public bool gameStart(){
		if(menu.player.gameObject.activeSelf){
			return true;
		}else{
			return false;
		}
	}

	public bool gameEnd(){
		menu.player.Die();
		if(menu.player.gameObject.activeSelf){
			return false;
		}else{
			return true;
		}
	}

	public bool ObstacleExisits(){
		//menu.player.pipeSystem.pipePrefab.
		return false;
	}
}
