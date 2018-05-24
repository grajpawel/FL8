using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpperMove2  : MonoBehaviour {
	public static bool hasPos = false;
	public static bool gameOn = true;
	public Vector2 tmpPos;
	public float moveSpeed;
	private float xpos = 9f;

	private bool addScore = true;

	public Color tmpCol;



	public bool hasZeroed = false;



	// Use this for initialization


	// Update is called once per frame
	void Update () {
		tmpPos = transform.position;
		if (UpperMove.score0 > 0 || UpperMove.score1 > 0)
			xpos = 5f;
		if (BirdMove.startGame == false)
			xpos = 10f;
			


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




		if (gameOn == false) {
			hasZeroed = false;
			addScore = true;

		}



		if (gameOn == true) {
			
			if (hasZeroed == false) {				
				moveSpeed = 0.03f;
				hasPos = false;
				hasZeroed = true;
			}
		


			if (tmpPos.x <= -2.1) {
					if (addScore == true) {
						if (PlayerPrefs.GetInt ("Mode") == 0)
							UpperMove.score0++;
						if (PlayerPrefs.GetInt ("Mode") == 1)
							UpperMove.score1++;

						addScore = false;

				}
			}
		}

		if (tmpPos.x <= -5f) {
			moveSpeed += 0.001f;
			hasPos = false;
			addScore = true;
		}
		if (BirdMove.startGame == true)
			tmpPos.x -= moveSpeed;

		if (hasPos == false) {
			addScore = true;
			tmpPos.x = xpos;
			tmpPos.y = Random.Range (2.0f, 9.0f);
			hasPos = true;
		}


		transform.position = tmpPos;	
	}
}
	
