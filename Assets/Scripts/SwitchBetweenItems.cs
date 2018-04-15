using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBetweenItems : MonoBehaviour {


	private int currentIndex=0;
	private int maxIndex=0;
	private GameObject model;

	public Button backButton;
	public Button nextButton;
	public Text text;

	// Use this for initialization
	void Start () {
		maxIndex = Collection.collection.Count;


		backButton.onClick.AddListener (decreaseIndex);
		nextButton.onClick.AddListener (increaseIndex);

		if(maxIndex>0)
		{
			text.text = Collection.collection [currentIndex];
			string path = "Prefabs/ModelPrefabs/" + text.text;
			model = (GameObject)Instantiate(Resources.Load(path));
		}


	}


	void decreaseIndex()
	{
		if (currentIndex > 0)
			currentIndex--;

		text.text = Collection.collection [currentIndex];
		Debug.Log ("Assets/Resources/Prefabs/ModelPrefabs/"+text.text);
		string path = "Prefabs/ModelPrefabs/" + text.text;
		Destroy (model);
		model = (GameObject)Instantiate(Resources.Load(path));

	}

	void increaseIndex()
	{
		if (currentIndex < maxIndex - 1)
			currentIndex++;

		text.text = Collection.collection [currentIndex];

		string path ="Prefabs/ModelPrefabs/" + text.text;
		Destroy (model);
		model = (GameObject)Instantiate(Resources.Load(path));

	}


}
