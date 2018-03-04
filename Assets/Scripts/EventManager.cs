using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {
	public delegate void GameOver();
	public static event GameOver GameOverEvent;

	// Use this for initialization
	void Start () {
		CollisionDetection.ObstacleCollisionEvent += GameOverHelper;
		GameOverEvent += Test;
		Debug.Log ("Start");
	}
		
	// Update is called once per frame
	void Update () {

	}

	// I wasn't sure how to trigger an event with another event so I used this useless method
	public void GameOverHelper(){
		if (GameOverEvent != null)
			GameOverEvent ();
	}

	public void Test() {
		Debug.Log ("GameOver");
	}

		
}
