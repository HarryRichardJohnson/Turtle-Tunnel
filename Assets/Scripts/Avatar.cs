using UnityEngine;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;
    public MainMenu mainMenu;

	private Player player;
    private Rigidbody rb;

	private bool onGround;

    public int coinScore = 1;

    public float deathCountdown = -1f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		onGround = true;
    }

    private void Awake () {
		player = transform.root.GetComponent<Player>();
	}

	private void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.CompareTag("Coin"))
        {
            mainMenu.UpdateCoinScore(coinScore);
            Destroy(collider.gameObject);
        }else
		if (!collider.gameObject.CompareTag("Coin") && deathCountdown < 0f) {
			shape.enableEmission = false;
			trail.enableEmission = false;
			burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
            player.velocity = 0.0f;
		}else{
			onGround = true;
		}
	}

    public void Jump()
    {
      	if(onGround){
			rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier -1) * Time.deltaTime;
      	}
        print("did I jump?");
		transform.position += Vector3.up * Time.deltaTime;
        Debug.Log ("In the air");

		
    }

	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Pipe")){
			onGround = true;
		}
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
