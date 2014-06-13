using UnityEngine;
using System.Collections;

public class Colission : MonoBehaviour {

	void Start () {
	}

	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.name == "Player") {

			Debug.Log("colsion Collision chronometer => "+GameManager.score);
			
			Time.timeScale = 0; //esto congela la escena
			GameManager.gameOver = true;

		}
	}


	void OnGUI()
	{
		if (GameManager.gameOver) {
			GUILayout.BeginArea (new Rect ((Screen.width / 2) - 60, (Screen.height / 2) - 60, Screen.width, Screen.height));
		
			GameManager.saveScore();
			GUI.Box (new Rect (0, 0, 150, 25), "Score: " + GameManager.score);
			
			if (GUI.Button (new Rect (0, 50, 150, 25), "Compartir tu logro")) {
				Application.LoadLevel ("SceneShare");
			}
			if (GUI.Button (new Rect (0, 75, 150, 25), "Try again!")) {
				Time.timeScale = 1; //reanuda la escena
				GameManager.score = 0;
				Application.LoadLevel ("SceneGame");
				GameManager.gameOver = false;
			}
			if (GUI.Button (new Rect (0, 100, 150, 25), "View best scores")) {
				Application.LoadLevel ("SceneScores");
			}
			GUILayout.EndArea ();
		} else {
				if (GameManager.gameStarted) {
					GUILayout.BeginArea (new Rect (0, 0, Screen.width, Screen.height));
					float val = GameManager.score;
					GUI.Box (new Rect (0, 0, 150, 25), "Score: " + val);

					float val2 = GameManager.bestScore;
					GUI.Box (new Rect (150, 0, 150, 25), "BEST Score: " + val2);
					GUILayout.EndArea ();
				}
		}
	}
}
