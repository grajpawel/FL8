using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class LeaderBoardButton : MonoBehaviour {
	public void OnTap(){
		Social.ShowLeaderboardUI();
	}
}
