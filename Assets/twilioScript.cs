using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class twilioScript : MonoBehaviour
{
	string url = "api.twilio.com/2010-04-01/Accounts/";
	string service="/Messages.json";
	 string from="+1nooooo44";
	string to="+191fmlhaha06";
	string account_sid="ACnicetry5c79ad8e5c1";
	string auth="e39617GG78f97f9";
	 string body;
//	Button obj;
//	Text t;

	void Start(){
//		 obj = GameObject.FindGameObjectWithTag ("debugbtn").GetComponent<Button> () ;
//		 t = obj.GetComponentInChildren<Text> ();
	}
	void Awake(){
//		Input.location.Start ();
//	
//		LocationInfo l = Input.location.lastData;


		body = "Hello, " + PlayerPrefs.GetString ("Name") + " seems to be lost, please reach them immediately!";
	}

	public void SendSMS ()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("To", to);
		form.AddField ("From", from);
		//string bodyWithoutSpace = body.Replace (" ", "%20");//Twilio doesn't need this conversion
		form.AddField ("Body", body);
		string completeurl = "https://"+account_sid+":" + auth +"@" +url+account_sid+service;
		Debug.Log (completeurl);
		WWW www = new WWW (completeurl, form);
		StartCoroutine (WaitForRequest (www));
	}

	IEnumerator WaitForRequest (WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null) {
			Debug.Log ("WWW Ok! SMS sent through Web API: " + www.text);
		} else {
//			t.text = www.error;
			Debug.Log ("WWW Error: " + www.error);
		}    
	}
}
