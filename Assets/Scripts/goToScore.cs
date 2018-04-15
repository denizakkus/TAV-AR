using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToScore : MonoBehaviour {



	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (toScore);
	}


	void toScore () { // When users press the any save button, will be direct to Main page.

		// GEREKLI SAVELERI YAPTIGIM BIR KAC ISLEM OLMASI LAZIM, DATABASEYE ATILIR, LOCALE ATILIR FARK ETMEZ.

		SceneManager.LoadScene ("Scoreboard"); // Switch the second scene.
	}

}
