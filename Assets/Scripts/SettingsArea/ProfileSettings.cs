using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProfileSettings : MonoBehaviour {


	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (gotoProfile); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
		printAlert();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void printAlert() { // is password wrong or true.

		Debug.Log ("You pressed on Profile Settings.");

	}
	void gotoProfile() {

		SceneManager.LoadScene ("UI_Settings_Profile"); // Switch the second scene.
	}
}
