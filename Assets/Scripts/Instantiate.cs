using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
	public GameObject WallScore;
	public GameObject [] Objects;
	public GameObject [] arrayGameObjects;
	public GameObject Player;
	public GameObject rastre;
	public List<GameObject> arrayFlags = new List <GameObject> ();
	public List<GameObject> arrayObjects = new List <GameObject> ();
	GameObject flags;
	GameObject objects;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("addFlags", 1f, 2.5f);
		InvokeRepeating ("addObjects", 3f, 0.5f);
	}
	// Update is called once per frame
	void Update () {
		//instantiate the elements behind the player
		rastre = Instantiate (rastre as GameObject);
		rastre.transform.position = Player.transform.position;
	}
	void addFlags () {
		//add flags arount the middle
		flags = Instantiate (WallScore as GameObject);
		flags.transform.position = new Vector3 (Random.Range(-1.5f, 0.5f), Player.transform.position.y -11, 0);
		arrayFlags.Add (flags);
	}

	void addObjects () {
		//instantiate objects with more probability of trees
		int x = Random.Range (0, 2);
		if (x == 1) {
			objects = Instantiate (Objects [1] as GameObject);
			if (x == 1) {
				objects.transform.position = new Vector3 (Random.Range (-3.0f, -0.5f), Random.Range (Player.transform.position.y - 13f, Player.transform.position.y - 15f), 0);
			} else {
				objects.transform.position = new Vector3 (Random.Range (0.5f, 3.0f), Random.Range (Player.transform.position.y - 13f, Player.transform.position.y - 15f), 0);
			}		
		} 
		else {
			GameObject objects = Instantiate (Objects [Random.Range (0, 5)] as GameObject);
			int y = Random.Range (0, 2);
			if (y == 1) {
				objects.transform.position = new Vector3 (Random.Range (-3.0f, -1.0f), Random.Range (Player.transform.position.y - 13f, Player.transform.position.y - 15f), 0);
			} else {
				objects.transform.position = new Vector3 (Random.Range (1.0f, 3f), Random.Range (Player.transform.position.y - 13f, Player.transform.position.y - 15f), 0);
			}
		}
		arrayObjects.Add (objects);
	}
	//checking bounds
	/*
	void check () {
		for (int i = 0; i < arrayObjects.Count-1; i++) {
			if (arrayObjects [i].GetComponent<BoxCollider2D> ()) {
				if (arrayObjects [i].GetComponent<BoxCollider2D> ().bounds.Intersects (arrayFlags [i].GetComponent<BoxCollider2D> ().bounds)) {
					Destroy (arrayObjects [i].gameObject);
				}
			}
		}
	}
	*/

}
