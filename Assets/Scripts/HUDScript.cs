﻿using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	
	float playerScore = 0;
	
	void Update() {
		playerScore += Time.deltaTime;
	}
	
	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 100));
		PlayerPrefs.Save ();
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int) (playerScore * 100)); 
	}
}