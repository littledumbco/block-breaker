using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Creating a basic function to handle loading levels
	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel (name);
	}

	// Creating another basic function for handling quitting the game
	public void QuitRequest (){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}



}
