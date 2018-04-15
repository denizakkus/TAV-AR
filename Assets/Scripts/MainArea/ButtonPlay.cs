using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (gotoPlay);
	}

	// Update is called once per frame
	void Update () {

	}

	void gotoPlay () { // When users press the any save button, will be direct to Main page.

		// GEREKLI SAVELERI YAPTIGIM BIR KAC ISLEM OLMASI LAZIM, DATABASEYE ATILIR, LOCALE ATILIR FARK ETMEZ.

		SceneManager.LoadScene ("MainScene"); // Switch the second scene.
	}
}
