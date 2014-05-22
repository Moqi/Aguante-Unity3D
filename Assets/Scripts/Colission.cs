using UnityEngine;
using System.Collections;

public class Colission : MonoBehaviour {

	private bool touch = true; //para que no me tome dos collisiones en el caso de que el objeto pegue con dos partes
	private bool show = false;
	void Start () {
	}

	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){

		if (touch && col.gameObject.name == "Player") {
			Debug.Log("colsion 2D");
			Destroy(col.gameObject);

			show = true;
			touch = false;
		}
	}


	void OnGUI()
	{
		if (show){
		GUILayout.BeginArea(new Rect((Screen.width/2)-60, (Screen.height/2)-60, Screen.width, Screen.height));
		
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2, 150, 25),"Don't try again, you are going to lose it anyway, because you are a LOOSER!")) 
		{
			Application.LoadLevel("SceneGame");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 + 25, 150, 25),"Run away, you coward! That's the only thing that you can do here.")) 
		{
			Application.Quit();
		}
		GUILayout.EndArea();
		}
	}
}
