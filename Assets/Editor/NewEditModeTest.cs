using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System.Collections;

[TestFixture]
public class NewEditModeTest {


	[Test]
	public void NewEditModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	//Tests

	[Test]
	public void T01ChangeScene() {
		//Change Scene test
		ChangeScene changescene = new ChangeScene();
		Assert.AreEqual("Main Menu", changescene);
	}

	//CoinBehaviour
		
	[Test]
	public void T02CoinTaken() {
		//Coin is taken
	}

	[Test]
	public void T03CoinExisits(){

	}


	[Test]
	public void T04PlayerMovesRight(){
		//turtle moves left
	}

	[Test]
	public void T05PlayerMovesLeft(){
		//turtle moves left
	}


	[Test]
	public void T06TurtleExisits(){

	}

	[Test]
	public void T06TunnelExisits(){
		//Update

	}


	[Test]
	public void T08PipeExisits(){
		//SetUpPipe
	}

	[Test] 
	public void T09PipeTurns(){

	}

	[Test] 
	public void T10ObstacleExisit(){

	}

	[Test]
	public void T11ObstacleInView(){

	}

	[Test]
	public void T12CoinInView(){

	}

	[Test]
	public void T13CoinRotates(){

	}

	[Test]
	public void T14GameGetsFaster(){
		
	} 

	[Test]
	public void T15MenuToSettings(){

	}

	[Test]
	public void T16MenuToGame(){

	}

	[Test]
	public void T17MenuToInstructions(){

	}

	[Test]
	public void T18TurtleJumps(){

	}



	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
/*	[UnityTest]
	public IEnumerator NewEditModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}*/


}
