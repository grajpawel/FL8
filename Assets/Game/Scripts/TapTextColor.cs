using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapTextColor : MonoBehaviour {
	public Text title;
	private Color tmp;
	private bool addcolor = true;
	// Use this for initialization
	void Start () {
		title = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		tmp = title.color;
		if (BirdMove.startGame == false) {
			if (addcolor == true) {
				tmp.a += 0.003f;
				if (tmp.a >= 0.30f)
					addcolor = false;
			}
			if (addcolor == false) {
				tmp.a -= 0.003f;
				if (tmp.a <= 0)
					addcolor = true;
			}
		} else {
			tmp.a -= 0.003f;
			if (tmp.a <= 0)
				tmp.a = 0;
		}
		title.color = tmp;
	}
}
