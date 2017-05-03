using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {

	[Test]
	public void NewEditModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

<<<<<<< HEAD
<<<<<<< HEAD
	//Tests

	[Test]
	public void T01ChangeScene() {
		//Change Scene test
//		ChangeScene changescene = new ChangeScene();
//		Assert.AreEqual("Main Menu", changescene);
	}

	//CoinBehaviour

	[Test]
	public void T02CoinExists(){
		Collider collider = new Collider ();
		bool doesExist = true;

		if ((collider.gameObject.CompareTag ("Coin")) != null) {
			Assert.IsTrue (doesExist);
		} else {
			Assert.IsFalse (doesExist);
		}
	}


	[Test]
	public void T03TurtleExisits(){
		if (GameObject.Find ("Turtle")) {
			Debug.Log ("Turtle Exists");
		} else {
			Debug.Log ("Turtlr doesn't exist");
		}
	}

	[Test]
	public void T04TunnelExisits(){
		//Update

	}


	[Test]
	public void T05PipeExisits(){
		if (GameObject.Find ("Pipe System")) {
			Debug.Log ("Pipes Exists");
		} else {
			Debug.Log ("Pipes doesn't exist");
		}
	}


	[Test] 
	public void T06ObstacleExisit(){
		/*bool exists = false;

		if (item.gameObject != 0) {
			Assert.IsTrue (exists);
			Debug.Log ("Obstacles Exists!");
		} else {
			Assert.IsFalse (exists);
			Debug.Log ("Obstacles does not exist!");
		}*/
	}


	[Test]
	public void T07CoinRotates(){
		CoinBehaviour cb = new CoinBehaviour ();
		Assert.AreEqual (cb.rotateSpeed, 50f);
	}

	[Test]
	public void T08GameGetsFaster(){
	/*	bool gamsIsFaster = false;
		Player player = new Player ();
		if (player.accelerations.Length != 0) {
			Assert.IsTrue (gamsIsFaster);
		} else {
			Assert.IsFalse (gamsIsFaster);
		}*/
	} 

	[Test]
	public void T09MenuToSettings(){
		MainMenu mm = new MainMenu ();

	}

	[Test]
	public void T10MenuToGame(){

	}

	[Test]
	public void T11MenuToInstructions(){

	}

	[Test]
	public void T12TurtleJumps(){

	}



=======
>>>>>>> parent of 97869c5... Tests to be completed
=======
>>>>>>> parent of 97869c5... Tests to be completed
	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
/*	[UnityTest]
	public IEnumerator NewEditModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
<<<<<<< HEAD
<<<<<<< HEAD
	}*/


=======
	}
>>>>>>> parent of 97869c5... Tests to be completed
=======
	}
>>>>>>> parent of 97869c5... Tests to be completed
}
