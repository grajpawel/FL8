using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class UpperMove : MonoBehaviour {
	public static bool hasPos = false;
	public static bool gameOn = true;
	public Vector2 tmpPos;
	public float moveSpeed;
	public static int score0;
	public static int score1;

	private bool addScore = true;

	public GUIStyle guiStyleScore = new GUIStyle();
	public GUIStyle guiStyleShadow = new GUIStyle();

	public Text scoreText;
	public Text scoreShadowText;
	public Text scoreText1;
	public Text scoreShadowText1;

	private Color tmp;
	private Color tmpShadow;
	private Color tmp0;
	private Color tmpShadow0;
	private Color tmp1;
	private Color tmpShadow1;
	private Color tmpCol;

	public bool hasZeroed = false;

	void Awake () {
		guiStyleScore.fontSize = Screen.width / 8;
		guiStyleShadow.fontSize = Screen.width / 8;

	}

	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {
		});
		score0 = 0;
		score1 = 0;
		hasPos = false;
		gameOn = true;
		addScore = true;
		hasZeroed = false;
		tmp0 = scoreText.color;
		tmp1 = scoreText1.color;
		tmpShadow0 = scoreShadowText.color;
		tmpShadow1 = scoreShadowText1.color;
		tmp = guiStyleScore.normal.textColor;
		tmp.a = 0;
		SetScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (UpperMove.score0 == 1 || UpperMove.score1 == 1) {
			Social.ReportProgress("CgkI_4i0zvscEAIQAQ", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 5 || UpperMove.score1 == 5) {
			Social.ReportProgress("CgkI_4i0zvscEAIQAg", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 10 || UpperMove.score1 == 10) {
			Social.ReportProgress("CgkI_4i0zvscEAIQAw", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 15 || UpperMove.score1 == 15) {
			Social.ReportProgress("CgkI_4i0zvscEAIQBA", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 20 || UpperMove.score1 == 20) {
			Social.ReportProgress("CgkI_4i0zvscEAIQBQ", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 25 || UpperMove.score1 == 25) {
			Social.ReportProgress("CgkI_4i0zvscEAIQBg", 100.0f, (bool success) => {
			});
		}
		if (UpperMove.score0 == 30 || UpperMove.score1 == 30) {
			Social.ReportProgress("CgkI_4i0zvscEAIQBw", 100.0f, (bool success) => {
			});
		}
		if (BirdMove.startGame == false)
			SetScoreText();
		
		tmpShadow.a = tmp.a / 7;
		tmpShadow1.a = tmp1.a / 7;
		tmpShadow0.a = tmp0.a / 7;
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



		tmpPos = transform.position;
		if (gameOn == false) {
			hasZeroed = false;
			addScore = true;
		}

		
	
		if (gameOn == true) {
			if (BirdMove.startGame == true){
				
			if (hasZeroed == false) {
				if (BirdMove.startGame == true) {
					if (PlayerPrefs.GetInt ("Mode") == 0)
						score0 = 0;
					if (PlayerPrefs.GetInt ("Mode") == 1)
						score1 = 0;
				}
				moveSpeed = 0.03f;
				hasPos = false;
				hasZeroed = true;
			}


			if (tmpPos.x <= -2.1) {
					if (addScore == true) {
						if (PlayerPrefs.GetInt ("Mode") == 0)
							score0++;
						if (PlayerPrefs.GetInt ("Mode") == 1)
							score1++;
					
						addScore = false;
					}
				}
			}
		}
			if (tmpPos.x <= -5f) {
				moveSpeed += 0.001f;
				hasPos = false;
				addScore = true;
			}
			if (BirdMove.startGame == true)
			tmpPos.x -= moveSpeed;

			if (hasPos == false) {
				addScore = true;
				tmpPos.x = 5f;
				tmpPos.y = Random.Range (2.0f, 9.0f);
				hasPos = true;
			}

		scoreText.color = tmp0;
		scoreText1.color = tmp1;
		scoreShadowText.color = tmpShadow0;
		scoreShadowText1.color = tmpShadow1;
			transform.position = tmpPos;	
		}



	void SetScoreText(){
		if (PlayerPrefs.GetInt ("Mode") == 0) {
			scoreText.text = score0.ToString ();
			scoreShadowText.text = score0.ToString ();
		}
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			scoreText1.text = score1.ToString ();
			scoreShadowText1.text = score1.ToString ();
		}

	}

	void OnGUI(){

		if (gameOn == true) {
			if (BirdMove.startGame == true)
				tmp.a += 0.005f;
			if (tmp.a >= 1)
				tmp.a = 1;
		}

		if (gameOn == false)
			tmp.a -= 0.03f;
		if (tmp.a <= 0)
			tmp.a = 0;
		guiStyleShadow.normal.textColor = tmpShadow;
		guiStyleScore.normal.textColor = tmp;
		if (PlayerPrefs.GetInt ("Mode") == 0) {
			tmp0.a += 0.02f;
			if (tmp0.a >= 1)
				tmp0.a = 1;
			tmp1.a -= 0.02f;
			if (tmp1.a <= 0)
				tmp1.a = 0;
			GUI.Label (new Rect (Screen.width / 1.96f, Screen.height / 8.96f, 0, 0), score0.ToString (), guiStyleShadow);
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 9f, 0, 0), score0.ToString (), guiStyleScore);
		}
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			tmp1.a += 0.02f;
			if (tmp1.a >= 1)
				tmp1.a = 1;
			tmp0.a -= 0.02f;
			if (tmp0.a <= 0)
				tmp0.a = 0;
			GUI.Label (new Rect (Screen.width / 1.96f, Screen.height / 8.96f, 0, 0), score1.ToString (), guiStyleShadow);
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 9f, 0, 0), score1.ToString (), guiStyleScore);
		}
	}
}
