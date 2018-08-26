using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private float verticalControls;
	[SerializeField] private float acceleration;
	[SerializeField] private float maxSpeed;
	// Multiplied by the acceleration to find force slowing down player when no controls are applied
	[SerializeField] private float decelerationFactor;

	private Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		Vector2.ClampMagnitude(rb.velocity, maxSpeed);
		//If there is no movement
		if(Mathf.Abs(verticalControls) < 0.001) {
			// Takes the currentVelocity, and adds a force in the opposite direction
			Vector2 currentVelocity = rb.velocity;
			Vector2 oppositeForce = -currentVelocity * acceleration* decelerationFactor;
			rb.AddForce(oppositeForce);
		} else {
			rb.AddForce(new Vector2(0f, verticalControls*acceleration));
		}
		rb.MoveRotation(rb.velocity.y * 5);
	}

	// Called from Player Input
	// v is dependant on input
	public void Move(float v) {
		verticalControls = v;
	}
}
