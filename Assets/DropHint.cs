using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropHint : MonoBehaviour {

	public Button button;
	public Text hintText;
	private bool waiting = false;

	private string [] items = { "Abstract", "Grass", "Mcd", "Pollock", "Rocks"}; 

	void Start()
	{
		button.onClick.AddListener (generateHint);
	}


	private void generateHint()
	{
		int randomIndex = Random.Range (0, items.Length);


		if(!Collection.collection.Contains(items[randomIndex]))//If we don't have the object in our collection already...
		{
			string path = "Prefabs/Riddle Prefabs/rd_" + items [randomIndex]; 


			if (!waiting) 
			{
				GameObject riddle = (GameObject)Instantiate (Resources.Load (path));

				StartCoroutine (ShowMessage (riddle.GetComponent<RiddleVariables> ().riddle, 3));
			}

		}
	}

	IEnumerator ShowMessage(string message,float delay)
	{
		hintText.text = message;
		waiting = true;
		yield return new WaitForSeconds (delay);
		hintText.text = "";
		waiting = false;

	}


	

}
