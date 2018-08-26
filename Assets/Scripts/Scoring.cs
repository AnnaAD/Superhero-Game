using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {
	private float distanceTraveled;
	private UIManager uiManager;
	private GenerateObstacles obstacleScript;
	// Use this for initialization
	void Start () {
		distanceTraveled = 0;
		uiManager = GameObject.Find ("UI").GetComponent<UIManager> ();
		obstacleScript = GameObject.Find("Obstacles").GetComponent<GenerateObstacles>();
	}
	
	// Update is called once per frame
	void Update () {
		distanceTraveled += obstacleScript.speed * (float)Time.deltaTime;
		uiManager.updateDistanceText (getDistanceTraveled());
		// Debug.Log (getDistanceTraveled ());
	}

	public int getDistanceTraveled() {
		return (int) distanceTraveled;
	}
}
