using UnityEngine;
using System.Collections;

public class ScoreClass : MonoBehaviour {

	public static double score = 0;
	
	void Start () {
	}
	
	void Update () {
		score = score + Time.deltaTime;
	}
}
