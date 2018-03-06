using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour
{
	float scrollSpeed;
	float tileSize = 15;
	public GameObject player;
	private Vector2 startPosition;
	float controlTime;
	void Start ()
	{
	}

	void Update ()
	{
		/* get the position of the player and repeat a math operation of scroll the sprite, to make the sprite "interactive" and not a static sprite,
		also, return in the position of the player after move a defined tileSize, to repeat again the process. */

		startPosition = player.transform.position;
		controlTime += Time.deltaTime;
		//Increase speed after 2s  
		if (controlTime < 2) {
			scrollSpeed = 1;
		} else {
			scrollSpeed = 2;
		} 
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSize);
		transform.position = startPosition + Vector2.down * newPosition; 

	}
}