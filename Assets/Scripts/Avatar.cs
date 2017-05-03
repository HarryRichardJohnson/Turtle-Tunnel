using UnityEngine;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;
    public MainMenu mainMenu;

	private Player player;
    private Rigidbody rb;

    private int coinScore = 1;

    public float deathCountdown = -1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake () {
		player = transform.root.GetComponent<Player>();
	}

	private void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.CompareTag("Coin"))
        {
            mainMenu.UpdateCoinScore(coinScore);
            Destroy(collider.gameObject); 
			print ("Got the coin!");
        }
		if (!collider.gameObject.CompareTag("Coin") && deathCountdown < 0f) {
			shape.enableEmission = false;
			trail.enableEmission = false;
			burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
            player.velocity = 0.0f;
		}
	}

    public void Jump()
    {
        rb.AddForce(0, 0, 8.0f, ForceMode.Force);
        //rb.AddForce(transform.forward * 8.0f);
       // rb.AddForce(Vector3.up * 8.0f);//, ForceMode.Impulse);
        print("did I jump?");
    }

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
