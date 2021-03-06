﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
public class BannerAd : MonoBehaviour {
	public BannerView bannerView;
	void Start(){
		RequestBanner ();
		}
	void Update(){
		if (BirdMove.startGame == true)
			bannerView.Hide ();
		else
			bannerView.Show ();
	}

	public void RequestBanner()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-2165871186692773/2228780043";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-2165871186692773/2228780043";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.

	
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
	
		bannerView.LoadAd(request);

		}
		}

	
	