using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	private GameObject distanceText; 
	// Use this for initialization
	void Start () {
		distanceText = GetComponent<Transform>().Find("DistanceText").gameObject; //Can also use .GetChild( int index);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateDistanceText(int distance) {
		distanceText.GetComponent<UnityEngine.UI.Text> ().text = distance + "m";
	}

}
