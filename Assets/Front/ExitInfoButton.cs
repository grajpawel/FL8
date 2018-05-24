using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInfoButton : MonoBehaviour {
	private int soundId;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("whosh");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTap(){
		if (PlayerPrefs.GetInt ("Sound") == 1) 
			AudioCenter.playSound (soundId);
		InfoButton.move = false;
	}
}
