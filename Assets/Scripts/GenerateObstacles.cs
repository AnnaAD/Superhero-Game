using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	[SerializeField] private GameObject[] obstacles;
	[SerializeField] private float timeBetweenBuildings;


	[SerializeField] public float speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeBetweenBuildings += Time.fixedDeltaTime;
		if(timeBetweenBuildings > 2.6) {
			timeBetweenBuildings = 0;
			int obj = Random.Range(0,obstacles.Length);

			GameObject instatiated = Instantiate(obstacles[obj]) as GameObject;
			instatiated.transform.position = new Vector2(Camera.main.ViewportToWorldPoint(new Vector2(1.2f,0)).x,obstacles[obj].transform.position.y);
			instatiated.transform.SetParent(this.transform);

		}
	}
}
