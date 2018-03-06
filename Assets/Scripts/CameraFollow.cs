using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform Player;
	// Use this for initialization
	void Start () {
		//
	}
	
	// Update is called once per frame
	void Update () {
		//follow the player in the y axis - 4
		transform.position = new Vector3 (transform.position.x, Player.transform.position.y-4, transform.position.z);
	}
}
