using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	[SerializeField] private GameObject[] staticObstacles;
	[SerializeField] private GameObject[] fastObstacles;
	[SerializeField] private float timeBetweenBuildings;
	private float countBetweenBuildings;
	// min and max values for nextFlyingTime
	[SerializeField] private int minFlyingTime;
	[SerializeField] private int maxFlyingTime;
	//Time since last flying obstacle
	private float flyingCount;
	// Total time between last obstacle and next obstacle
	private float nextFlyingTime;
	//The speed of all obstacles, effectivally the horizontal speed of the player
	[SerializeField] public float speed;
	[SerializeField] public float acceleration;
	// Use this for initialization
	void Start () {
		countBetweenBuildings = timeBetweenBuildings * 3/4;
		flyingCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Updates speed of player
		speed += acceleration * Time.fixedDeltaTime;
		
		countBetweenBuildings += Time.fixedDeltaTime;
		flyingCount += Time.fixedDeltaTime;
		//Generates buildings
		if(countBetweenBuildings > timeBetweenBuildings / speed) {
			countBetweenBuildings = 0;
			int obj = Random.Range(0,staticObstacles.Length);
			GameObject instatiated = Instantiate(staticObstacles[obj]) as GameObject;
			instatiated.transform.position = new Vector2(Camera.main.ViewportToWorldPoint(new Vector2(1.2f,0)).x,staticObstacles[obj].transform.position.y);
			instatiated.transform.SetParent(this.transform);
		}

		// Generates Flying Objects
		if(flyingCount > nextFlyingTime / speed) {
			flyingCount = 0;
			nextFlyingTime = Random.Range(minFlyingTime, maxFlyingTime);
			int obj = Random.Range(0, fastObstacles.Length-1);
			Debug.Log(obj);
			GameObject instatiated = Instantiate(fastObstacles[obj]) as GameObject;
			instatiated.transform.position = Camera.main.ViewportToWorldPoint(new Vector2(1.2f,Random.Range(0.3f,1.0f)));
			instatiated.transform.SetParent(this.transform);

		}
	}
}
