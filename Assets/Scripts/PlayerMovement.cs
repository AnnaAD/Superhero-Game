using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private float verticalControls;
	[SerializeField] private float acceleration;
	[SerializeField] private float maxSpeed;

	private Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		Vector2.ClampMagnitude(rb.velocity, maxSpeed);
		rb.AddForce(new Vector2(0f, verticalControls*acceleration));
		if(Mathf.Abs(verticalControls) < 0.01) {
			Vector2 currentVelocity = rb.velocity;
			Vector2 oppositeForce = -currentVelocity * 2;
			rb.AddForce(oppositeForce);
		}
		rb.MoveRotation(rb.velocity.y * 5);
	}

	public void Move(float v) {
		verticalControls = v;
	}
}
