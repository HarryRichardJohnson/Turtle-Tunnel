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

    private int coinScore = 1;

    public float deathCountdown = -1f;

    //Initialises the shape of the avatar
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake () {
		player = transform.root.GetComponent<Player>();
	}

    //This method deals with collision detection if the player collides with an obstacle or coin.
	private void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.CompareTag("Coin")) // If collides with coin
        {
            mainMenu.UpdateCoinScore(coinScore);
            Destroy(collider.gameObject); 
			print ("Got the coin!");
        }
		if (!collider.gameObject.CompareTag("Coin") && deathCountdown < 0f) { // If collides with anything that is NOT a coin
			shape.enableEmission = false;
			trail.enableEmission = false;
			burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
            player.velocity = 0.0f;
		}
	}

    //This method holds functionality for making the user jump
    public void Jump()
    {
        rb.AddForce(0, 0, 8.0f, ForceMode.Force);
        //rb.AddForce(transform.forward * 8.0f);
        // rb.AddForce(Vector3.up * 8.0f);//, ForceMode.Impulse);
        print("did I jump?");
    }

    //This method deals with updated the player as the game is played. 
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
