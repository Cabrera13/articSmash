using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	float offSet;
	public GameObject objectPlayer;
	// Use this for initialization
	void Start () {
		offSet =  objectPlayer.transform.position.y - transform.position.y;
	}
	// Update is called once per frame
	void Update () {
		//follow the player in the y 
		transform.position = new Vector3(transform.position.x, objectPlayer.transform.position.y - offSet, transform.position.z);
	}
}
