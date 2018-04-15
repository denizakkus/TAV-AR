using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCollection : MonoBehaviour {



	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (gotoCollection);
		Debug.Log ("I am in the Collection area ma boi");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void gotoCollection () {

		SceneManager.LoadScene ("UI_Collection"); // Switch the second scene.

	}
}
