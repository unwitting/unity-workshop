using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	// The static singleton provides a reference available from anywhere
	// to the one ScoreCounter in the game
	public static ScoreCounter singleton;

	public int score;

	void Start () {
		// When the ScoreCounter starts up, it should set the global singleton to itself...
		ScoreCounter.singleton = this;
		// ...and show a "0" on screen
		ResetScore ();
	}

	public void IncrementScore () {
		score++;
		RenderScore ();
	}

	public void ResetScore () {
		score = 0;
		RenderScore ();
	}

	void RenderScore () {
		// Lots of "text" here - we're getting the Text component (fully, it's UnityEngine.UI.Text),
		// and setting its .text member variable to our score
		Text textComponent = GetComponent<Text> ();
		textComponent.text = score.ToString ();
	}
}
