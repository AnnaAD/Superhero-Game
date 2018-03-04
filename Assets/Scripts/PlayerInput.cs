using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerInput : MonoBehaviour {

	private PlayerMovement playerMovement;

	void Awake() {
		playerMovement = GetComponent<PlayerMovement>();
	}

	private void FixedUpdate() {
		float v = CrossPlatformInputManager.GetAxis("Vertical");
		// Pass all parameters to the character control script.
		playerMovement.Move(v);
	}
}
