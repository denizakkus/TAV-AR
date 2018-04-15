using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckCollection : MonoBehaviour {

	public Button button;

	// Use this for initialization
	void Start () {
		button.onClick.AddListener (switchToCollectionScene);
	}

	void switchToCollectionScene()
	{
		SceneManager.LoadScene ("UI_Collection");

	}
}
