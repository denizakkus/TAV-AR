using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toBeLogin : MonoBehaviour {


	public InputField getName, getPassword; // I can take the components of inputfields easly.
	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button>().onClick.AddListener (checkPassword); // Scriptsin gomulu oldugu buttonı alıyorum (getComponent) ve button oldugunu belirtiyorum <Button>
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void checkIsTheUserNameInTheDB () { // is this username exist in databse.


	}

	void checkPassword() { // is password wrong or true.

		if (getPassword.text == "MOMO") { // default password will be "MOMO".

			Debug.Log ("YEA");
			SceneManager.LoadScene ("UI_HowtoPlay"); // Switch the second scene.

		} else { // ben anlarım ki bu adam databasede mevcut degil

			Debug.Log ("Sorry dude, you can not login without SIGN UP.");
		}
	}
}
