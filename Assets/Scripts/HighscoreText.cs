﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreText : MonoBehaviour {

	Text score;

	void OnEnable() {
		score = GetComponent<Text>();
		score.text = "Yüksek Skor: " +PlayerPrefs.GetInt("HighScore").ToString();
	}
}
