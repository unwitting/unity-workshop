using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	void Update () {
		// Each frame, check whether the ball has fallen
		DetectFall ();
	}

	void OnCollisionExit2D () {
		// Called when the ball leaves a bounce with another object
		// We want to add a point to the score
		ScoreCounter.singleton.IncrementScore ();
	}

	void DetectFall () {
		if (transform.position.y < -15) {
			Reset ();
		}
	}

	void Reset () {
		// Move back to starting position
		transform.position = new Vector2 (0, 5);

		// Set all velocity to zero
		Rigidbody2D rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = Vector2.zero;
		rigidBody.angularVelocity = 0;

		// Reset the score to 0
		ScoreCounter.singleton.ResetScore ();
	}
}
