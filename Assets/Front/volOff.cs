using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (AudioListener.volume == 0)
			tmp.a = 1;
	}

	// Update is called once per frame
	void Update () {
		
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (gameObject.name == "Shadow1" || gameObject.name == "Shadow2") {
			if (tmp.a >= 0.15f)
				tmp.a = 0.15f;
		}
		if (PlayerPrefs.GetInt ("Sound") == 0) {

			if (tmp.a >= 1)
				tmp.a = 1;
			
			tmp.a += 0.015f;
		} else {
			tmp.a -= 0.015f;
			if (tmp.a <= 0)
				tmp.a = 0;
			
		}
	


		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
