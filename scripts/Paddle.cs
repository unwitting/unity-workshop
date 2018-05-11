using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// How fast the paddle moves when we press an arrow key
	public float speed;

	void Update () {
		// Input.GetKey() tells us "is this key currently pressed this frame?"
		if (Input.GetKey ("left")) {
			MoveLeft ();
		}
		if (Input.GetKey ("right")) {
			MoveRight ();
		}
	}

	void MoveLeft () {
		// Time.deltaTime is the time (in seconds) since the last frame
		// Therefore, if you move by Time.deltaTime each frame, then over 1s you'll move 1 unit
		// With " * speed" you'll move at speed units / second
		float distanceToMove = Time.deltaTime * speed;
		MoveByDistance (distanceToMove);
	}

	void MoveRight () {
		float distanceToMove = Time.deltaTime * speed;
		MoveByDistance (distanceToMove);
	}

	void MoveByDistance (float distance) {
		// We can't assign parts of a vector directly (like transform.position.x = blah;)
		// so we construct a new vector with the same Y value as the old one
		transform.position = new Vector2 (
			transform.position.x + distance,
			transform.position.y
		);
	}
}
