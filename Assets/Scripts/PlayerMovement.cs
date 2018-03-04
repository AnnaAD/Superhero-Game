using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private float verticalControls;
	[SerializeField] private float speed;
	private Rigidbody2D rb;

	void Awake() {
		rb = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		rb.AddForce(new Vector2(0f, verticalControls*speed));
		if(Mathf.Abs(verticalControls) < 0.01) {
			Vector2 currentVelocity = rb.velocity;
			Vector2 oppositeForce = -currentVelocity * 2;
			rb.AddRelativeForce(oppositeForce);
		}
	}

	public void Move(float v) {
		verticalControls = v;
	}
}
