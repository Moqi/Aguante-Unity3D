using UnityEngine;
using System.Collections;

public class Colission : MonoBehaviour {

	private bool showGameOver = false;


	void Start () {
	}

	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.name == "Player") {


			Debug.Log("colsion Collision chronometer => "+ScoreClass.score);
			
			Time.timeScale = 0; //esto congela la escena
			showGameOver = true;

		}
	}


	void OnGUI()
	{
		if (showGameOver){
		GUILayout.BeginArea(new Rect((Screen.width/2)-60, (Screen.height/2)-60, Screen.width, Screen.height));
		
			if (GUI.Button(new Rect(0, 0, 150, 25),"Score: "+ScoreClass.score)) 
			{
			
			}
		if (GUI.Button(new Rect(0, 25, 150, 25),"Try again!")) 
		{
			Time.timeScale = 1; //reanuda la escena
			ScoreClass.score = 0;
			Application.LoadLevel("SceneGame");
		}
		if (GUI.Button(new Rect(0, 50, 150, 25),"View best scores")) 
		{
				Application.LoadLevel("SceneScores");
		}
		GUILayout.EndArea();
		}
	}
}
