using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {
	private float distanceTraveled;
	private readonly float SPEED = 10f;
	private UIManager uiManager;

	// Use this for initialization
	void Start () {
		distanceTraveled = 0;
		uiManager = GameObject.Find ("UI").GetComponent<UIManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		distanceTraveled += SPEED * (float)Time.deltaTime;
		uiManager.updateDistanceText (getDistanceTraveled());
		// Debug.Log (getDistanceTraveled ());
	}

	public int getDistanceTraveled() {
		return (int) distanceTraveled;
	}
}
