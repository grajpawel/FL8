using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRot : MonoBehaviour {
	private int tpRand;
	public static int rotate = 0;
	public static bool hasRot = false;
	private int soundId;
	private Color tmpCol;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("woosh");

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 1){
			tmpCol = GetComponent<SpriteRenderer> ().color;

			if (BirdMove.startGame == true) {
				tmpCol.a += 0.015f;	
				if (tmpCol.a >= 1)
					tmpCol.a = 1;
			} else {
				tmpCol.a -= 0.015f;
				if (tmpCol.a <= 0)
					tmpCol.a = 0;
			}
			GetComponent<SpriteRenderer> ().color = tmpCol;
		if (UpperMove.gameOn == false) {
			rotate = 0;
			hasRot = false;
		}
			if (UpperMove.score1 >= 1) {
				if (GameObject.Find ("upper").transform.position.x <= -4.99f) {
					tpRand = Random.Range (0, 2);
					Debug.Log (tpRand);
					if (tpRand == 1)
						transform.position = new Vector2 (GameObject.Find ("upper").transform.position.x + 0.5f, GameObject.Find ("upper").transform.position.y - 5.4f);
					else
						transform.position = new Vector2 (transform.position.x, -180);
				}
			} else 
				transform.position = new Vector2 (transform.position.x, -180);
		} else 
			transform.position = new Vector2 (transform.position.x, -180);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Bird") {
			if (PlayerPrefs.GetInt ("Sound") == 1) 
				AudioCenter.playSound (soundId);
			transform.position = new Vector2 (transform.position.x, -180);
			rotate++;
				
		}
	}
			
}
