using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void Restart() {
		Debug.Log ("Restart");
		SceneManager.LoadScene ("Game");
	}

	public void Quit() {
		Debug.Log ("Attempting to Quit");
		Application.Quit();
	}


}
