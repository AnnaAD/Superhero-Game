using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CollisionDetection.ObstacleCollisionEvent += EndGame;
	}
		
	public void EndGame() {
		SceneManager.LoadScene ("EndgameMenu");
	}


		
}
