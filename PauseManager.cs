﻿using UnityEngine; 
using UnityEngine.SceneManagement;
using System.Collections; 
using UnityEngine.UI;

public class PauseManager : MonoBehaviour 
{ 

	Canvas canvas;
	void Start () 
	{ 
		canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
	} 

	void Update () 
	{ 
		if(Input.GetKeyDown(KeyCode.Escape))
		{ 
			Pause();
		} 
	}
	public void Pause() 
	{ 
		canvas.enabled = !canvas.enabled;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	} 
	public void MenuLevels()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		SceneManager.LoadScene("Menu_N");
	}
} 