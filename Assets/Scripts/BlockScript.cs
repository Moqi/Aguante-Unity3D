using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

		
		private Vector3 ballPosition;
		private Vector2 ballInitialForce;
		
		// GameObject
		public GameObject playerObject;
		
		// Use this for initialization
		void Start () {

			// create the force
			ballInitialForce = new Vector2 (50.0f,150.0f);
			
			// reset the force
			rigidbody2D.isKinematic = false;
		
			// add a force
			rigidbody2D.AddForce(ballInitialForce);
		
			// ball position
			ballPosition = transform.position;

			// set game active
			GameManager.gameStarted = true;
	}
		
		// Update is called once per frame
		void Update () {

		//ScoreClass.score += Time.deltaTime;

		// check for user input
		//if (Input.GetButtonDown ("Jump") == true) {	}
			
		if (!GameManager.gameStarted && playerObject != null){
				
				// get and use the player position
				ballPosition.x = playerObject.transform.position.x;
				ballPosition.y = playerObject.transform.position.y;
				
				// apply player X position to the object
				transform.position = ballPosition;
			}
		}

		void OnCollisionEnter2D(Collision2D col){
		if ( col.gameObject.name == "Player" ) {
			Debug.Log("colsion BlockScript");
			//Time.timeScale = 0; //detiene la escena
			//Destroy(col.gameObject);
			
		}
	}

	}
