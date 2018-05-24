using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Bird") {
			BirdMove.startGame = false;
			UpperMove.gameOn = false;
			UpperMove2.gameOn = false;
			Debug.Log ("col");

		}
		}
}
