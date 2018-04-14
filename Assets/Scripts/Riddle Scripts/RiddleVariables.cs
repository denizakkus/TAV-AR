using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleVariables : MonoBehaviour {

	public string riddle;//The actual riddle itself.
	public GameObject imageTarget;//The ACTUAL image target that the riddle is referring to

	// Use this for initialization
	void Start ()
	{
		initializeImageTarget ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	void initializeImageTarget()//initializes our image target object
	{
		imageTarget = (GameObject)Instantiate(imageTarget);
	}


	void generateRandomRiddle()//Generates a random, unsolved riddle
	{


	}
		

}
