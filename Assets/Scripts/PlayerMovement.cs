using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private float verticalControls;
	[SerializeField] private float acceleration;
	[SerializeField] private float maxSpeed;
	// Multiplied by the acceleration to find force slowing down player when no controls are applied
	[SerializeField] private float decelerationFactor;

	//Rigidbody and transform components of Player
	private Rigidbody2D rb;
	private Transform trans;
	//Obstacle generation Script
	GenerateObstacles obstScript;
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
		obstScript = GameObject.Find("Obstacles").GetComponent<GenerateObstacles>();
	}
	// Update is called once per frame
	void Update () {
		Vector2.ClampMagnitude(rb.velocity, maxSpeed * obstScript.speed);
		//If there is no movement
		if(Mathf.Abs(verticalControls) < 0.001 || trans.position.y > 5 || trans.position.y < -5) {
			// Takes the currentVelocity, and adds a force in the opposite direction
			Vector2 currentVelocity = rb.velocity;
			Vector2 oppositeForce = -currentVelocity * acceleration * obstScript.speed * decelerationFactor;
			rb.AddForce(oppositeForce);
		} else {
			rb.AddForce(new Vector2(0f, verticalControls*acceleration * obstScript.speed));
		}
		rb.MoveRotation(rb.velocity.y * 15 / obstScript.speed);
		if(trans.position.y > 5) {
			trans.position = new Vector3(trans.position.x, 5, trans.position.z);
		} else if(trans.position.y < -5) {
			trans.position = new Vector3(trans.position.x, -5, trans.position.z);
		}
	}

	// Called from Player Input
	// v is dependant on input
	public void Move(float v) {
		verticalControls = v;
	}
}
