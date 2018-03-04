using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
	private float speed;
	// Use this for initialization
	void Start () {
		speed = GetComponentInParent<GenerateObstacles>().speed;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(transform.position.x - (speed*Time.fixedDeltaTime), transform.position.y);
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
		
}
