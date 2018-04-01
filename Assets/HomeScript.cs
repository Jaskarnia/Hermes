using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour {
	private twilioScript twi;
	private Button button;
	void Awake(){
		button = GetComponent<Button>();
		twi = GetComponent<twilioScript> ();

		button.onClick.AddListener (OnClick);
	}
	void OnClick(){
		twi.SendSMS ();
		PlayerPrefs.SetInt("Scene",SceneManager.GetActiveScene().buildIndex);
		UnityEngine.SceneManagement.SceneManager.LoadScene (3);
	}
}
