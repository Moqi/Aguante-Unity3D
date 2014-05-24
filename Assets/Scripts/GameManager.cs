using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static string playerPrefsBestScore = "bestScore";

	public static float score = 0;
	public static float bestScore;
	public static bool gameStarted = false;
	public static bool gameOver = false;

	// Use this for initialization
	void Start () {
		score = 0;
		bestScore = PlayerPrefs.GetFloat("bestScore");
		gameStarted = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameStarted) {
			score = score + Time.deltaTime;
		}
	}

	public static void saveScore(){

		if (bestScore < score)
			PlayerPrefs.SetFloat(playerPrefsBestScore, score);
		PlayerPrefs.Save();
		
	}

}

