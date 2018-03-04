using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private float verticalControls;

	void Awake() {
		
	}
	// Update is called once per frame
	void Update () {

	}

	public void Move(float v) {
		verticalControls = v;
	}
}
