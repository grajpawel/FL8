using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	private Vector3 tmpPos;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		tmpPos = transform.position;


		if (UpperMove.gameOn == false) {
			

			
			tmpPos.x -= 0.15f;
			if (tmpPos.x <= -8f) 			
				tmpPos.x = -8f;
			
		}
		if (UpperMove.gameOn == true) {
			
			if (tmpPos.x != 0) {
				tmpPos.x += 0.15f;
				if (tmpPos.x >= 0f)
					tmpPos.x = 0f;
			}
		}

				transform.position = tmpPos;	
				
	}
}
