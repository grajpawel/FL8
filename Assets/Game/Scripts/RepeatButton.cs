using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatButton : MonoBehaviour {
	private int soundId;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("whosh");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTap(){		
		if (UpperMove.gameOn == false) {
			if (PlayerPrefs.GetInt ("Sound") == 1) 
			AudioCenter.playSound (soundId);
			UpperMove.gameOn = true;
			UpperMove2.gameOn = true;
		}

	}
}
