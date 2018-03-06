using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {
	public Text myText;
	public GameObject GameController;
	int points;
	int best;
	// Use this for initialization
	void Start () {
		
		//Manage the score with the GameController prefab 
		points = GameController.GetComponent<GameController> ().getScore ();
		best = GameController.GetComponent<GameController> ().getBest ();

		//change the text 

		myText.text = "Score:   " + points + "\n" + "HighScore: "+best ;

	}
	
	// Update is called once per frame
	void Update () {
		//
	}
}
