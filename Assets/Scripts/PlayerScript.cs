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

		if (GameManager.gameOver) {
						Time.timeScale = 0; //esto congela la escena
				} else {


			if (Input.touchCount>0){
				Vector2 pos = Input.GetTouch(0).deltaPosition;//Input.GetTouch(0).position;

				playerPosition.x += pos.x * playerVelocity;
				playerPosition.y += pos.y * playerVelocity;
			}


						// horizontal movement
						//playerPosition.x += Input.GetAxis ("Horizontal") * playerVelocity;
						//playerPosition.y += Input.GetAxis ("Vertical") * playerVelocity;
		
						// leave the game
						if (Input.GetKeyDown (KeyCode.Escape)) {
								Application.Quit ();
						}
		
						// update the game object transform
						transform.position = playerPosition;
				}
	}
}
