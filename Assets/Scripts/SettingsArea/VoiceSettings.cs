using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoiceSettings : MonoBehaviour {


	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (gotoVoice); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void printAlert() { // is password wrong or true.

		Debug.Log ("You pressed on Voice Settings");

	}
	void gotoVoice () {

		SceneManager.LoadScene ("UI_Settings_Voice");
	}
}
