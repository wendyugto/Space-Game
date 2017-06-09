﻿using UnityEngine;
using System.Collections;

// UnityEngine.UI is needed to handle <Text> in the canvas (e.g. SCORE and LIVES)
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI2 : MonoBehaviour {

	public int currentScore = 0; // currentScore is increased from alienController
	public bool isGameOver; // from playerController
	public int playerLives; // from playerController

	private Text livesText;
	private Text scoreText;
	private Text gameOverText;

	// Use this for initialization
	void Start () {

		// Get text labels
		livesText = GameObject.Find("Lives").GetComponent<Text>();
		scoreText = GameObject.Find("Score").GetComponent<Text>();
		gameOverText = GameObject.Find("GameOver").GetComponent<Text>(); // Disabled by default in the inspector

	}

	// NB. Update is not affected by Time.timeScale (i.e. it also works during Game Over)
	void Update () {

		playerLives = GameObject.Find("Player").GetComponent<playerController>().playerLives;
		isGameOver = GameObject.Find("Player").GetComponent<playerController>().isGameOver;

		// Update scores and lives on every frame
		livesText.text = "LIVES: "+playerLives;
		scoreText.text = "SCORE: "+currentScore;

		if (isGameOver) {
			gameOverText.enabled = true;
		}
		if (currentScore == 15)
			SceneManager.LoadScene ("SceneWin2");
		}
}