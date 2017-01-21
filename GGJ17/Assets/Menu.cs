﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject pauseMenu;

	public void StartGame(){
		SwitchScene.GotoScene ("Lukas scene");
	}
	public void ExitGame(){
		Application.CancelQuit ();
	}
	public void Pause(){
		Time.timeScale = 0;
		pauseMenu.SetActive (true);
	}
	public void UnPause(){
		Time.timeScale = 1;
		pauseMenu.SetActive (false);
	}
}
