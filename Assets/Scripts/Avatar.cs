﻿using UnityEngine;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;
    public MainMenu mainMenu;

	private Player player;

    private int coinScore = 1;

    public float deathCountdown = -1f;

	private void Awake () {
		player = transform.root.GetComponent<Player>();
	}

	private void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.CompareTag("Coin"))
        {
            mainMenu.UpdateCoinScore(coinScore);
            Destroy(collider.gameObject);
        }
		if (!collider.gameObject.CompareTag("Coin") && deathCountdown < 0f) {
			shape.enableEmission = false;
			trail.enableEmission = false;
			burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
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
