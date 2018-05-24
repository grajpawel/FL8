using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerMove2 : MonoBehaviour {
	private Vector2 tmpPos;
	public Color tmpCol;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		tmpCol = GetComponent<SpriteRenderer> ().color;

		if (BirdMove.startGame == true) {
			tmpCol.a += 0.015f;	
			if (tmpCol.a >= 1)
				tmpCol.a = 1;
		} else {
			tmpCol.a -= 0.03f;
			if (tmpCol.a <= 0)
				tmpCol.a = 0;
		}
		GetComponent<SpriteRenderer> ().color = tmpCol;
		tmpPos = transform.position;
		if (UpperMove.hasPos == true) {
			tmpPos.y = GameObject.Find ("upper2").transform.position.y - 10.75f;
			tmpPos.x = GameObject.Find ("upper2").transform.position.x - 0.03f;
		}
		transform.position = tmpPos;	

	}

}
