using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RiddleGeneration : MonoBehaviour {

	private List<string> generatedRiddles{get;set;}//The list of already-generated riddles
	private List<string> nonGeneratedRiddles{get;set;}//The list of riddles that HAVENT been generated yet

	public string currentImageName;

	void Start()
	{
		initializeNonGeneratedRiddles (); //Initialize the nonGeneratedRiddles
		generatedRiddles = new List<string>();//Initialize the generatedRiddles
		generateRandomRiddle();//Generate a random riddle
	}

	void Update()
	{
		foreach(GameObject g in Object.FindObjectsOfType<GameObject>())
		{
			if (g.CompareTag ("IT") && g.name.Substring(3)!=currentImageName) {
			
				//g.SetActive (false);
			}
		}

	}




	void initializeNonGeneratedRiddles()
	{
		nonGeneratedRiddles = new List<string> ();//Initialize the riddles

		DirectoryInfo dir = new DirectoryInfo ("Assets/Resources/Prefabs/Riddle Prefabs");
		FileInfo[] info = dir.GetFiles ("*.prefab");

		foreach (FileInfo file in info) //Loop through all prefabs
		{
			if(file.Name.StartsWith("rid"))//If this prefab is a riddle prefab
			{
				nonGeneratedRiddles.Add (file.Name);//Add the riddle to the list
			}
		}

	}



	void generateRandomRiddle()//Generates a random riddle from the list of nonGenerated Riddles
	{
		int randomIndex = Random.Range (0, nonGeneratedRiddles.Count);	//The random index of the newly generated riddle

		generatedRiddles.Add (nonGeneratedRiddles[randomIndex]);//Add the item to the already-generated list


		Debug.Log (Path.GetFileNameWithoutExtension(nonGeneratedRiddles[randomIndex]));
		currentImageName = Path.GetFileNameWithoutExtension (nonGeneratedRiddles [randomIndex]);//Set your name to the current image
		currentImageName=currentImageName.Substring(4);

		nonGeneratedRiddles.RemoveAt (randomIndex);//Remove the item from the list

	}
}
