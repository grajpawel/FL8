using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMove : MonoBehaviour {
	private Vector2 pos;
	private int Rand;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		if (BirdMove.startGame == false)
			Rand = 30;
		else 
			Rand = Random.Range (14, 14);
		pos = transform.position;
		pos.x -=  GameObject.Find ("upper").GetComponent<UpperMove> ().moveSpeed/Rand;
		if (pos.x <= -22)
			pos.x = 5f;


		transform.position = pos;	


	}
}
