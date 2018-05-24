using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBGMove : MonoBehaviour {
	private Vector2 tmpPos;
	private Quaternion tmpRot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tmpPos = transform.position;
		tmpRot = transform.rotation;
		tmpPos.x += 0.00f;
		tmpRot.z += 0.0001f;
		transform.rotation = tmpRot;
		transform.position = tmpPos;	

	}
}
