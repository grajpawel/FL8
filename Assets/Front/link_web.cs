﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class link_web: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}
		
	public void OnTap (){

		Application.OpenURL("https://papl0.wordpress.com/");
	}
}

