using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	public delegate void ObstacleCollision();
	public static event ObstacleCollision ObstacleCollisionEvent;

	public void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag.Equals ("Obstacle")) {
			Debug.Log ("Collided!");
			if (ObstacleCollisionEvent != null) {
				ObstacleCollisionEvent ();
			} else
				Debug.Log ("null");
		}
	}
}
