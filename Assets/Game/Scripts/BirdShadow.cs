using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdShadow : MonoBehaviour {

	private Color tmp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		tmp.a = BirdMove.tmp.a / 7;
		GetComponent<SpriteRenderer> ().color = tmp;



	}
}
