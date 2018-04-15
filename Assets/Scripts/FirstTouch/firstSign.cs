using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firstSign : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button>().onClick.AddListener (almostFinish); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
	}

	// Update is called once per frame
	void Update () {

	}

	void almostFinish () {

		SceneManager.LoadScene ("UI_SignUp"); // Switch the second scene.
	}
}
