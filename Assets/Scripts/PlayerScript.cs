using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerVelocity;
	private Vector3 playerPosition;
	public Vector2 previousTouch;
	private float lerpTime;
	// Use this for initialization
	void Start () {
		// get the initial position of the game object
		playerPosition = gameObject.transform.position;
		previousTouch = new Vector2(playerPosition.x, playerPosition.y);
		lerpTime = 0.1f;

	

	}
	
	// Update is called once per frame
	void Update () {

		if (GameManager.gameOver) {
						Time.timeScale = 0; //esto congela la escena
				} else {

			 //El objeto se mueve al punto seleccionado y compruebo si choco con algo.
			if (Input.GetMouseButtonDown(0) ){
				Vector3 p1 = transform.position;
				Vector3 p2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				//RaycastHit2D h = Physics2D.LinecastNonAlloc(p1, p2); //para ahorrar memoria
			
				RaycastHit2D hit = Physics2D.Linecast(p1, p2);
				if (hit.collider != null ){
					Debug.Log("choque con... "+ hit.collider.name);
					transform.position = new Vector2(hit.point.x, hit.point.y);
					GameManager.gameOver = true;
				} else {
					transform.position = new Vector2(p2.x,p2.y);
				}
			}

			/*
			if (Input.touches.Length > 0){
				if (Input.touches[0].phase == TouchPhase.Began)
				{
					Vector2 actualTouch = new Vector2(Input.touches[0].deltaPosition.x,Input.touches[0].deltaPosition.y);
					Vector2.Lerp(previousTouch,actualTouch,lerpTime);

					previousTouch = actualTouch;
					
				}
			} else

			if (Input.GetMouseButtonDown.Length > 0){
				Vector2 actualTouch = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
				Vector2.Lerp(previousTouch,actualTouch,lerpTime);
				previousTouch = actualTouch;

			}*/

			//ANDAAAAAAAAAAAA
			/*if (Input.touches.Length > 0){
				// Solo funcionará con el primer touch
				// y solo si se mueve durante el último update
				if (Input.touches[0].phase == TouchPhase.Moved)
				{
					var x = Input.touches[0].deltaPosition.x * playerVelocity * Time.deltaTime;
					var y = Input.touches[0].deltaPosition.y * playerVelocity * Time.deltaTime;
					
					transform.Translate(new Vector2(x, y));
					
				}
			}*/


			/*if (Input.touchCount>0){
				Vector2 pos = Input.GetTouch(0).deltaPosition;//Input.GetTouch(0).position;

				playerPosition.x += pos.x;// * playerVelocity;
				playerPosition.y += pos.y;// * playerVelocity;
			}*/


						// horizontal movement
						//playerPosition.x += Input.GetAxis ("Horizontal") * playerVelocity;
						//playerPosition.y += Input.GetAxis ("Vertical") * playerVelocity;
		
						// leave the game
						/*if (Input.GetKeyDown (KeyCode.Escape)) {
								Application.Quit ();
						}
		
						// update the game object transform
						transform.position = playerPosition;*/

			}



		/*
		if(Input.touchCount > 0){                          
			if(Input.GetTouch(0).phase == TouchPhase.Began){
				var ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
				if(Physics.Raycast (ray, hit, 1000000)){        
					if(hit.collider.gameObject.name == "Drag"){            
						GameObjectSeleccionado = hit.collider.gameObject;               
						screenPoint = Camera.main.WorldToScreenPoint(GameObjectSeleccionado.transform.position);                               
					}              
				}
			}else if(Input.GetTouch(0).phase == TouchPhase.Moved){     
				GameObjectSeleccionado.transform.position = Camera.main.ScreenToWorldPoint(Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y, screenPoint.z));       
				
			}else if(Input.GetTouch(0).phase == TouchPhase.Ended){        
				GameObjectSeleccionado = null;
			}
		}  */
	}
}
