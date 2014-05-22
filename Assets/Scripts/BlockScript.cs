using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

		private bool ballIsActive;
		private Vector3 ballPosition;
		private Vector2 ballInitialForce;
		
		// GameObject
		public GameObject playerObject;
		
		

		// Use this for initialization
		void Start () {
			// create the force
			ballInitialForce = new Vector2 (50.0f,150.0f);
			
			// set to inactive
			ballIsActive = false;
			
			// ball position
			ballPosition = transform.position;
		}
		
		// Update is called once per frame
		void Update () {
		// check for user input
		if (Input.GetButtonDown ("Jump") == true) {
			// check if is the first play
			if (!ballIsActive){
				// reset the force
				rigidbody2D.isKinematic = false;
				
				// add a force
				rigidbody2D.AddForce(ballInitialForce);
				
				// set ball active
				ballIsActive = !ballIsActive;
			}
		}
			
			if (!ballIsActive && playerObject != null){
				
				// get and use the player position
				ballPosition.x = playerObject.transform.position.x;
				ballPosition.y = playerObject.transform.position.y;
				
				// apply player X position to the object
				transform.position = ballPosition;
			}
			
			
		}

	/*void OnCollisionEnter2D(Collision2D collision){
		if (ballIsActive) {
			Debug.Log("cagaste!");
			//audio.PlayOneShot (hitSound);
		}
	}*/

	}
