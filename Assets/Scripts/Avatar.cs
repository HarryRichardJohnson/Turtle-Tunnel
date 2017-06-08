/*
This script holds instance variables and methods used for the actual player character.
It deals with the hit detection and collision with items/obstacles as well as the shape.
*/

using UnityEngine;

public class Avatar : MonoBehaviour {

    //Instance variables
	public ParticleSystem shape, trail, burst;
    public MainMenu mainMenu;

	private Player player;
    private Rigidbody rb;

	private bool onGround;

    public static int coinScore = 1;

    public float deathCountdown = -1f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public AudioSource[] AudioSources;

    public AudioSource collisionAudioSource;
    public AudioSource coinAudioSource;
    public AudioSource jumpAudioSource;

	private Animator anim;


    //Initialises the shape of the avatar
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		onGround = true;
		anim = GetComponent<Animator>();

        AudioSources = this.GetComponents<AudioSource>();

        coinAudioSource = AudioSources[0];
        collisionAudioSource = AudioSources[1];
        jumpAudioSource = AudioSources[2];
    }

    private void Awake () {
		player = transform.root.GetComponent<Player>();


    }


    /*This method deals with collision detection if the player collides with an obstacle or coin.
    It also stops the trail when collision with an obstacle as well as emits a burst or particles as the player loses
    */
    private void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.CompareTag("Coin")) // if collides with coin
        {
			if (PlayerSound.isSoundOn) {
				coinAudioSource.Play ();
			}
            mainMenu.UpdateCoinScore(coinScore);
            Destroy(collider.gameObject);
        }
        else
		if (!collider.gameObject.CompareTag("Coin") && deathCountdown < 0f) { // if collides with any obstacle
			if (PlayerSound.isSoundOn) {
				collisionAudioSource.Play ();
			}
            shape.enableEmission = false;
			trail.enableEmission = false;
            burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
            player.velocity = 0.0f;
        }
        else{
			onGround = true;
		}
	}

    //This method holds functionality for making the user jump
    public void Jump()
    {
    	if(anim) {
    		anim.SetTrigger("JumpTrigger");
    	}
    	
		if (PlayerSound.isSoundOn) {
			jumpAudioSource.Play ();
		}

		print("Did i jump");
		
    }

 


    //This method deals with updating the player as the game is played. 
    private void Update () {
       
		if (deathCountdown >= 0f) {
			deathCountdown -= Time.deltaTime;
			if (deathCountdown <= 0f) {
				deathCountdown = -1f;
				shape.enableEmission = true;
				trail.enableEmission = true;
				player.Die();
			}
		}
	}
}
