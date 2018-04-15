using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toBeSignup : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button>().onClick.AddListener (directPassing); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void directPassing () {

		SceneManager.LoadScene ("UI_HowtoPlay"); // Switch the second scene.
	}
}
