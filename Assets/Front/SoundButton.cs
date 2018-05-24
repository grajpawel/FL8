using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {



	// Use this for initialization
	void Start () {

		if (PlayerPrefs.HasKey ("Sound")) {
		}
		else {
			PlayerPrefs.SetInt("Sound", 1);

		}

	}


	 public void OnTap(){


		if (PlayerPrefs.GetInt ("Sound") == 1) {
			PlayerPrefs.SetInt ("Sound", 0);

		}else {
			PlayerPrefs.SetInt("Sound", 1);

		}
	}
}

