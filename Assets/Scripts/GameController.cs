using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	//static vars that store information through all the scenes
	public static int score = 0;
	public static int best = 0;

	// getters and setters
	public void setScore (int sc) {
		score = sc;
	}
	public int getBest () {
		//PlayerPrefs is a library to store the information in local storage, doesn't matter if we stop the execution and we run it again, it's always saved in local.

		return PlayerPrefs.GetInt ("highscore");
		}
	public void setBest (int b) {
		//first parameter of setInt is the name of the variable that we want to store in local, and the second parameter is the integer variable.
		PlayerPrefs.SetInt ("highscore", b);
	}
	public int getScore () {
		return score;
	}
}
