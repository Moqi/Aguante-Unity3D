using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerVelocity;
	private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
		// get the initial position of the game object
		playerPosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// horizontal movement
		playerPosition.x += Input.GetAxis ("Horizontal") * playerVelocity;
		playerPosition.y += Input.GetAxis ("Vertical") * playerVelocity;
		
		// leave the game
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
		
		// update the game object transform
		transform.position = playerPosition;
	}
}
