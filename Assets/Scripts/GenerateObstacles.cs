using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	[SerializeField] private GameObject obstacle;
	[SerializeField] public float speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range(0,50) == 1) {
			GameObject instatiated = Instantiate(obstacle) as GameObject;
			instatiated.transform.position = Camera.main.ViewportToWorldPoint(new Vector2(1.1f,Random.Range(0.0f,1.0f)));
			instatiated.transform.SetParent(this.transform);
		}
	}
}
