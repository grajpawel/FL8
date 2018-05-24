using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CamMoveRb : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (UpperMove.gameOn == false) {
			if (InfoButton.move == true)
				transform.DOMove (new Vector2 (-16, 0), 1.5f);
			else
			transform.DOMove (new Vector2 (-8, 0), 1.5f);


		}
		if (UpperMove.gameOn == true) {
			transform.DOMove (new Vector2 (0, 0), 1.5f);
		}
	}
}
			