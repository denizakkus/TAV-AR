using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APITest : MonoBehaviour {

	private string URL = "http://35.159.15.121:8080/foodAndBeverage/restaurantList?language=en&location=ist";

	public Text responseText;

	void Start()
	{
		Request ();
	}

	private void Request()
	{
		WWW request = new WWW (URL);

		StartCoroutine (OnResponse (request));

	}

	private IEnumerator OnResponse (WWW request)
	{
		yield return request;

		responseText.text = request.text;

	}



}
