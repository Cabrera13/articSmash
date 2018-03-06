using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {
	public float Speed = 3;
	Rigidbody2D rg;
	public float maxSpeed = 5f;
	public GameObject SceneController;
	public GameObject GameController;
	float controllTime;
	int points = 0;
	int best;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		/*
		float speed = Input.GetAxis("Horizontal") * Speed;
		transform.Translate(speed * Time.deltaTime,0,0);
		*/
		//set the gravity scale to 0.01 after 6 seconds to make the game more playable 
		controllTime += Time.deltaTime;
		if (controllTime >= 6) {
			rg.gravityScale = 0.01f;
		}
		//controll the movement
		//if (rg.velocity.magnitude > maxSpeed) {
		//	rg.velocity = rg.velocity.normalized * maxSpeed;
		//}
		if (rg) {
			//movement mechanic
			rg.AddForce (new Vector2 (Input.GetAxis ("Horizontal") * Speed, 0.0f));
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		//check if is colliding with the trigger of the prefab of flag score named wallscore 
		if (other.gameObject.tag == "WallScore") {
			SceneController.GetComponent<ScoreController> ().addPoints();
		} 
		else {
			//sort the order to -1 of the spriterender to see the player in the front of the sprites when is in the same position of their shadow sprites.
			other.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = GetComponent<SpriteRenderer> ().sortingOrder - 1;
		}
	}
	void OnCollisionEnter2D (Collision2D element) {
		//check if is not colliding with the Limit Wall
		if (element.gameObject.tag != "LimitWall") {
			//manage the ScoreController points before load de scene
			points = SceneController.GetComponent<ScoreController> ().getPoints ();
			GameController.GetComponent<GameController> ().setScore (points);
			best = GameController.GetComponent<GameController> ().getBest ();
			if (best == 0) {
				GameController.GetComponent<GameController> ().setBest (points);
			} else if (points > best) {
				GameController.GetComponent<GameController> ().setBest (points);
			}
			//load the last scene
			SceneManager.LoadScene ("Scene3");
		}
	}

}