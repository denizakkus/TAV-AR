using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillOutScore : MonoBehaviour {

	public Text yourScore;


	void Start()
	{
		yourScore.text = "Your Score - " + PlayerVariables.score;

	}

}
