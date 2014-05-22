#pragma strict

function Start () {

}

function Update () {

}

function OnGUI () {
	var buttonSize : GUILayoutOption[] = [GUILayout.Width(120)];
  
    GUILayout.BeginArea(new Rect((Screen.width/2)-60, (Screen.height/2)-60, Screen.width, Screen.height));
       
       
  
  if ( GUILayout.Button("Start Game",buttonSize ) ) {
    Application.LoadLevel("SceneGame");
  }
  if ( GUILayout.Button("Exit",buttonSize ) ) {
   		print ("Exit!");
  }

 GUILayout.EndArea();
}