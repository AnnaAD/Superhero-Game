using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastObstacleMovement : MonoBehaviour {
	[SerializeField] private float speedAdditive;
	private float speed;
	// Use this for initialization
	void Start () {
		speed = GetComponentInParent<GenerateObstacles>().speed + speedAdditive;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(transform.position.x - (speed*Time.fixedDeltaTime), transform.position.y);
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}
