using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotGameObj : MonoBehaviour {
	
	private Vector3 targetAngles;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update ()
	{

	
		if (UpperMove.gameOn == false) {
			targetAngles = 0 * Vector3.forward;
		}
		if (BirdMove.startGame == true) {

			if (ScreenRot.rotate % 2 == 1) {
				targetAngles = 180f * Vector3.forward;
				

			} else {
				targetAngles = 0f * Vector3.forward;
			}
		}
		transform.eulerAngles = Vector3.Lerp (transform.eulerAngles, targetAngles, Time.deltaTime * 2);
	}
}
					