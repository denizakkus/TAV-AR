using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button>().onClick.AddListener (gotoSettings); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void gotoSettings() {

		SceneManager.LoadScene ("UI_Settings_Application"); // Switch the second scene.
	}
}
