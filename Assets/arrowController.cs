using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.location.Start ();
		Input.compass.enabled = true;

		if(!Input.gyro.enabled)
		{
			Input.gyro.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		float targetDirection = 270 - Input.compass.trueHeading;
		Debug.Log("true heading is " + targetDirection);
		transform.rotation = Quaternion.Euler(-135, 0, 90+ targetDirection);
//		gameObject.transform.rotation  = Input.gyro.attitude;

	}
}
