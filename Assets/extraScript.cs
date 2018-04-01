using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class extraScript : MonoBehaviour {

	private Button button;
	void Awake(){
		
		button = GetComponent<Button>();

		button.onClick.AddListener (OnClick);
	}
	void OnClick(){

			PlayerPrefs.SetString ("Sce", "true");
			PlayerPrefs.SetInt("Scene",SceneManager.GetActiveScene().buildIndex);
			UnityEngine.SceneManagement.SceneManager.LoadScene (5);
		}



}
