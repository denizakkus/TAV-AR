using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ApplicationSettings : MonoBehaviour {


	public Button btnProfile;
	public Button btnVoice;
	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (printAlert); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
		btnProfile.onClick.AddListener (switchProfileScenes);
		btnVoice.onClick.AddListener (switchVoiceScenes);
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	void printAlert() { // is password wrong or true.

		Debug.Log ("You pressed on Application Settings.");
		
	}
	void switchProfileScenes() {

		SceneManager.LoadScene ("UI_Settings_Profile"); // Switch the second scene.
	}

	void switchVoiceScenes() {

		SceneManager.LoadScene ("UI_Settings_Voice"); // Switch the second scene.
	}
}
