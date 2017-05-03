using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {

	public PipeSystem pipeSystem;

	public float startVelocity;
	public float rotationVelocity;

	public MainMenu mainMenu;
	public HUD hud;

	public float[] accelerations;

	private Pipe currentPipe;

	public float acceleration, velocity;
	private float distanceTraveled;
	private float deltaToRotation;
	private float systemRotation;
	private float worldRotation, avatarRotation;
    public Avatar avatar;

    private Vector2 touchOrigin = -Vector2.one;

	private Transform world, rotater;

	public void StartGame (int accelerationMode) {
		
		distanceTraveled = 0f;
		avatarRotation = 0f;
		systemRotation = 0f;
		worldRotation = 0f;
		acceleration = accelerations[accelerationMode];
		velocity = startVelocity;
		currentPipe = pipeSystem.SetupFirstPipe();
		SetupCurrentPipe();
		gameObject.SetActive(true);
		hud.SetValues(distanceTraveled, velocity);
	}

	public void Die () {
		mainMenu.EndGame(distanceTraveled);
		gameObject.SetActive(false);

	}

	private void Awake () {
		world = pipeSystem.transform.parent;
		rotater = transform.GetChild(0);
		gameObject.SetActive(false);
	}

	private void Update () {
		velocity += acceleration * Time.deltaTime;
		float delta = velocity * Time.deltaTime;
		distanceTraveled += delta;
		systemRotation += delta * deltaToRotation;

		if (systemRotation >= currentPipe.CurveAngle) {
			delta = (systemRotation - currentPipe.CurveAngle) / deltaToRotation;
			currentPipe = pipeSystem.SetupNextPipe();
			SetupCurrentPipe();
			systemRotation = delta * deltaToRotation;
		}

		pipeSystem.transform.localRotation =
			Quaternion.Euler(0f, 0f, systemRotation);
		
		UpdateAvatarRotation();

		GetMouseInput ();

		//add gravity
        //rotater.localRotation = Quaternion.Euler(0f, -8.0f, 0f);

        hud.SetValues(distanceTraveled, velocity);
	}

	private void GetMouseInput(){
		
		if ((Input.GetMouseButton (0)) || (Input.GetMouseButton(1))) {
			Vector3 mousePos = Input.mousePosition;
			Debug.Log ("X Co-ordinate:" + mousePos.x);
			Debug.Log ("Y Co-ordinate:" + mousePos.y);
		}
	}

    private void UpdateAvatarRotation()
    {
        float rotationInput = 0f;
        if (Application.isMobilePlatform)
        {
            if (Input.touchCount == 1)
            {
                if (Input.GetTouch(0).position.x < Screen.width * 0.5f)
                {
                    rotationInput = -1f;
                }
                else
                {
                    rotationInput = 1f;
                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            print("I am jumping");
            avatar.Jump();
        }
        else
        {
            rotationInput = Input.GetAxis("Horizontal");
        }
        avatarRotation += rotationVelocity * Time.deltaTime * rotationInput;
        if (avatarRotation < 0f)
        {
            avatarRotation += 360f;
        }
        else if (avatarRotation >= 360f)
        {
            avatarRotation -= 360f;
        }

        rotater.localRotation = Quaternion.Euler(avatarRotation, 0f, 0f);
    }




    /* float rotationInput = 0f;

     //mobile input
     if (Application.isMobilePlatform)
     {

         //if user has tapped screen
         if (Input.touchCount == 1)
         {
             if (Input.GetTouch(0).position.x < Screen.width * 0.5f)
             {
                 rotationInput = -1f;
             }
             else
             {
                 rotationInput = 1f;
             }
         }
          //if user has swiped
          else
          {
              Touch myTouch = Input.touches[0];

              if (myTouch.phase == TouchPhase.Began)
              {
                  touchOrigin = myTouch.position;
              }
              else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
              {
                  Vector2 touchEnd = myTouch.position;
                  float x = touchEnd
              }
          }
     }

     //keyboard input
     else
     {
         //if (inputDirection == InputDirection.Left || inputDirection == InputDirection.Right)
         // {

         rotationInput = Input.GetAxis("Horizontal");

         avatarRotation += rotationVelocity * Time.deltaTime * rotationInput;
         if (avatarRotation < 0f)
         {
             avatarRotation += 360f;
         }
         else if (avatarRotation >= 360f)
         {
             avatarRotation -= 360f;
         }
     }
         rotater.localRotation = Quaternion.Euler(avatarRotation, 0f, 0f);
         /* }
          else if (inputDirection == InputDirection.Top)
          {
              rotater.localRotation = Quaternion.Euler(0f, 8.0f, 0f);
          }*/


	private void SetupCurrentPipe () {
		deltaToRotation = 360f / (2f * Mathf.PI * currentPipe.CurveRadius);
		worldRotation += currentPipe.RelativeRotation;
		if (worldRotation < 0f) {
			worldRotation += 360f;
		}
		else if (worldRotation >= 360f) {
			worldRotation -= 360f;
		}
		world.localRotation = Quaternion.Euler(worldRotation, 0f, 0f);
	}
}