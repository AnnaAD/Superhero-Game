using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	[SerializeField] private GameObject[] staticObstacles;
	[SerializeField] private GameObject[] fastObstacles;
	[SerializeField] private float timeBetweenBuildings;
	private float countBetweenBuildings;
	[SerializeField] private int chanceOfExtraObstacle;


	[SerializeField] public float speed;
	// Use this for initialization
	void Start () {
		countBetweenBuildings = 0;
	}
	
	// Update is called once per frame
	void Update () {
		countBetweenBuildings += Time.fixedDeltaTime;
		if(countBetweenBuildings > timeBetweenBuildings) {
			countBetweenBuildings = 0;
			int obj = Random.Range(0,staticObstacles.Length-1);

			GameObject instatiated = Instantiate(staticObstacles[obj]) as GameObject;
			instatiated.transform.position = new Vector2(Camera.main.ViewportToWorldPoint(new Vector2(1.2f,0)).x,staticObstacles[obj].transform.position.y);
			instatiated.transform.SetParent(this.transform);

		}

		if(Random.Range(0,chanceOfExtraObstacle) == 1) {
			int obj = Random.Range(0, fastObstacles.Length-1);
			Debug.Log(obj);

			GameObject instatiated = Instantiate(fastObstacles[obj]) as GameObject;
			instatiated.transform.position = Camera.main.ViewportToWorldPoint(new Vector2(1.2f,Random.Range(0.3f,1.0f)));
			instatiated.transform.SetParent(this.transform);

		}
	}
}
