using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	[SerializeField] private GameObject[] obstacles;
	[SerializeField] private float timeBetweenBuildings;

	//The speed of all obstacles, effectivally the horizontal speed of the player
	[SerializeField] public float speed;
	[SerializeField] public float acceleration;
	// Use this for initialization
	void Start () {
		timeBetweenBuildings = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeBetweenBuildings += Time.fixedDeltaTime;
		speed += Time.fixedDeltaTime * acceleration;
		if(timeBetweenBuildings > 2.6) {
			timeBetweenBuildings = 0;
			int obj = Random.Range(0,obstacles.Length);

			GameObject instatiated = Instantiate(obstacles[obj]) as GameObject;
			instatiated.transform.position = new Vector2(Camera.main.ViewportToWorldPoint(new Vector2(1.2f,0)).x,obstacles[obj].transform.position.y);
			instatiated.transform.SetParent(this.transform);

		}
	}
}
