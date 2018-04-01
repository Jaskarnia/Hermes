using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScriptCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		{
			// Insert Code Here (I.E. Load Scene, Etc)
			// OR Application.Quit();
			UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerPrefs.GetInt("Scene"));
			return;
		}
	}
}
