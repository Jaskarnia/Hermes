using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneButtonScript : MonoBehaviour {

	private Button button;
	public InputField namee;
	public InputField number;
	public InputField location;
	public Toggle toggle;

	// Use this for initialization
	void Awake(){
		PlayerPrefs.SetString ("Child", "yes");
		button = GetComponent<Button>();

		button.onClick.AddListener (OnClick);
	}
	void OnClick(){
		PlayerPrefs.SetString ("Name", namee.text);
		PlayerPrefs.SetString ("Number", number.text);
		PlayerPrefs.SetString ("Location", location.text);
		if (toggle.isOn) {
			PlayerPrefs.SetString ("Child", "false");
			UnityEngine.SceneManagement.SceneManager.LoadScene (2);
		} else {
			PlayerPrefs.SetString ("Child", "true");
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
		}


	}

}
