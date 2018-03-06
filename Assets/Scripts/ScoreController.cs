using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	public int score;
	public Text myText;

	// Use this for initialization
	void Start () {
	//inicialize the score to 0 for every game
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void addPoints() {
		//add points and update the text
		score += 1;
		myText.text = "Score : " + score;

	}
	//get the points
	public int getPoints () {
		return score;
	}
		
}
