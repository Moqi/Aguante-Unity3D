using UnityEngine;
using System.Collections;

public class ScoreClass : MonoBehaviour {

	public static double score = 0;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score = score + Time.deltaTime;
	}
}
