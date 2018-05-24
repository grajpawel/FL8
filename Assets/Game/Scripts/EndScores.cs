using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScores : MonoBehaviour {

	public Text highScoreText;
	public Text highScoreShadowText;
	public Text highScoreText1;
	public Text highScoreShadowText1;

	public Color highScoreTextColor;
	public Color highScoreShadowTextColor;
	public Color highScoreText1Color;
	public Color highScoreShadowText1Color;


	// Use this for initialization
	void Start () {
		highScoreTextColor = highScoreText.color;
		highScoreShadowTextColor = highScoreShadowText.color;
		highScoreText1Color = highScoreText1.color;
		highScoreShadowText1Color = highScoreShadowText1.color;
	}
	
	// Update is called once per frame
	void Update () {
		highScoreShadowTextColor.a = highScoreTextColor.a / 7;
		highScoreShadowText1Color.a = highScoreText1Color.a / 7;

			
			SetScoreText ();
			if (PlayerPrefs.GetInt ("Mode") == 0) {
				highScoreTextColor.a += 0.02f;
				if (highScoreTextColor.a >= 1)
					highScoreTextColor.a = 1;
				highScoreText1Color.a -= 0.02f;
				if (highScoreText1Color.a <= 0)
					highScoreText1Color.a = 0;
				if (PlayerPrefs.HasKey ("Highscore0")) {
					if (PlayerPrefs.GetInt ("Highscore0") < UpperMove.score0) {
						PlayerPrefs.SetInt ("Highscore0", UpperMove.score0);
					}	
				} else {
					PlayerPrefs.SetInt ("Highscore0", UpperMove.score0);
				}
			}
			if (PlayerPrefs.GetInt ("Mode") == 1) {
				highScoreText1Color.a += 0.02f;
				if (highScoreText1Color.a >= 1)
					highScoreText1Color.a = 1;
				highScoreTextColor.a -= 0.02f;
				if (highScoreTextColor.a <= 0)
					highScoreTextColor.a = 0;
				if (PlayerPrefs.HasKey ("Highscore1")) {
					if (PlayerPrefs.GetInt ("Highscore1") < UpperMove.score1) {
						PlayerPrefs.SetInt ("Highscore1", UpperMove.score1);
					}	
				} else {
					PlayerPrefs.SetInt ("Highscore1", UpperMove.score1);
				}
			}


		highScoreText.color = highScoreTextColor;
		highScoreShadowText.color = highScoreShadowTextColor;
		highScoreText1.color = highScoreText1Color;
		highScoreShadowText1.color = highScoreShadowText1Color;
	}
	void SetScoreText(){
		if (PlayerPrefs.GetInt ("Mode") == 0) {
			highScoreShadowText.text = PlayerPrefs.GetInt ("Highscore0").ToString ();
			highScoreText.text = PlayerPrefs.GetInt ("Highscore0").ToString ();
		}
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			highScoreShadowText1.text = PlayerPrefs.GetInt ("Highscore1").ToString ();
			highScoreText1.text = PlayerPrefs.GetInt ("Highscore1").ToString ();
		}
	}
}
