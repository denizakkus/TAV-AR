using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testLeaderBoard : MonoBehaviour {


	//public Button btnPlay; // biraz zor, o yüzden sona bıraktım.


	public Color newColor = Color.blue;

	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (gotoScoreBoard);


		Debug.Log ("I am in the Score area ma boi");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void gotoScoreBoard () {


		ColorBlock cb = gameObject.GetComponent<Button> ().colors;
		cb.normalColor = Color.green;
		cb.highlightedColor = Color.green;
		//cb.pressedColor = newColor;

		gameObject.GetComponent<Button> ().colors = cb;
		SceneManager.LoadScene ("UI_MainScreen"); // Switch the second scene.

	}
}