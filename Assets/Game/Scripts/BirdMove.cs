using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class BirdMove : MonoBehaviour {
	private Rigidbody2D rb;
	private Vector2 pos;
	private bool jump = false;
	private bool hasZeroed = false;
	public static bool startGame = false;
	private int soundId;
	private int soundFail;

	public static Color tmp;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		soundId = AudioCenter.loadSound ("jump2");
		soundFail = AudioCenter.loadSound ("whosh");
	}
	
	// Update is called once per frame
	void Update () {
					
		tmp = GetComponent<SpriteRenderer> ().color;
		pos = transform.position;
		if (startGame == false) {
			rb.isKinematic = true;
			tmp.a -= 0.03f;
			if (tmp.a <= 0) 
				tmp.a = 0;
		} else {
			rb.isKinematic = false;
			if (tmp.a >= 1) 
				tmp.a = 1;

			tmp.a += 0.015f;
		}
		
		CheckPos ();
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				
				Jump ();
			}
		}
		if (Input.GetKeyDown ("space")) {			
			if (jump == false) {
				Jump ();		
				jump = true;
				}
			}

		if (Input.GetKeyUp ("space"))
			jump = false;
	
		GetComponent<SpriteRenderer> ().color = tmp;
		transform.position = pos;	
	}
	void Jump(){
		if (UpperMove.gameOn == true){
			if (startGame == false) {
				UpperMove.score0 = 0;
				UpperMove.score1 = 0;
				startGame = true;
			}
			if (startGame == true) {
				if (PlayerPrefs.GetInt ("Sound") == 1) 
				AudioCenter.playSound (soundId);
				rb.AddForce (Vector2.up * 200);
			}
		}
	}
		void CheckPos(){
		if (UpperMove.gameOn == true) {
			if (hasZeroed == false) {
				rb.velocity = Vector2.zero;
				pos.y = 0;
				hasZeroed = true;
			}
		} else
			hasZeroed = false;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name != "rotate") {
			if (PlayerPrefs.GetInt ("Mode") == 0) {
				Social.ReportScore (UpperMove.score0, "CgkI_4i0zvscEAIQCA", (bool success) => {
				});
			}

			if (PlayerPrefs.GetInt ("Mode") == 1) {
				Social.ReportScore (UpperMove.score1, "CgkI_4i0zvscEAIQCQ", (bool success) => {
				});
			}
				
			if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (soundFail);
			rb.velocity = Vector2.down * 2;
			startGame = false;
			UpperMove.gameOn = false;
			UpperMove2.gameOn = false;

		}
			

		}




		
}
