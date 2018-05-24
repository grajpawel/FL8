using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("Mode")) {
			} else {
			PlayerPrefs.SetInt ("Mode", 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<Image> ().color;

		if (PlayerPrefs.GetInt ("Mode") == 0) {
			tmp.a -= 0.005f;
			if (tmp.a <= 0)
				tmp.a = 0;
		} else {
			if (tmp.a >= 0.15f)
				tmp.a = 0.15f;
			
			tmp.a += 0.005f;
		}
		GetComponent<Image> ().color = tmp;
			
	}
	public void OnTap(){
		if (PlayerPrefs.GetInt ("Mode") == 0)
			PlayerPrefs.SetInt ("Mode", 1);
		else
			PlayerPrefs.SetInt ("Mode", 0);
	}
		
		
}
