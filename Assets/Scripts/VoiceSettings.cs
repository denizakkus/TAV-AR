using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoiceSettings : MonoBehaviour {


	public Button btnApplication;
	public Button btnProfile;

	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (printAlert); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
		btnProfile.onClick.AddListener (switchProfileScenes);
		btnProfile.onClick.AddListener (switchProfileScenes);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void printAlert() { // is password wrong or true.

		Debug.Log ("You pressed on Voice Settings");

	}
	void switchApplicationeScenes() {

		SceneManager.LoadScene ("UI_Settings_Application"); // Switch the second scene.
	}

	void switchProfileScenes() {

		SceneManager.LoadScene ("UI_Settings_Profile"); // Switch the second scene.
	}
}
