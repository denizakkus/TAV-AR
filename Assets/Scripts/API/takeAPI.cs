using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeAPI : MonoBehaviour {

	private string URL = "http://35.159.15.121:8080/foodAndBeverage/restaurantList?language=en&location=ist";
	public Text responseText;
	public Dropdown dropDown;

	private List <string> resultsList = new List <string>();

	void Start() {
		Request ();
	}

	private void Request() {
		gameObject.GetComponent<Button>().onClick.AddListener (letsStartogetAPI);

	}

	void letsStartogetAPI () {

		WWW request = new WWW (URL);
		StartCoroutine (OnResponse (request));
	}
	private IEnumerator OnResponse (WWW request) {
		yield return request;
		//responseText.text = request.text;

		int lenghtOfResult;
		PhotoData pd = PhotoData.CreateFromJSON (request.text);


		lenghtOfResult = pd.results.Length;
		for (int i = 0; i < lenghtOfResult; i++) {

			Debug.Log("[" + i + "] ıncı title : " + pd.results[i].title);
			resultsList.Add (pd.results[i].title);
		}

		dropDown.ClearOptions ();
		dropDown.AddOptions (resultsList);
		//Debug.Log ("AS2: " + pd.results[0].title);


		//MyObject[] Mo = parseJsonToObject (request.text);
		//restInfo[] r = restInfo.CreateFromJSON (li);
		//responseText.text = r.title;
		//Debug.Log (Mo[0].title);

		//responseText.text = request.text;

	}



	[System.Serializable]
	public class PhotoData {

		public string status;
		public int num_results;
		public Item[] results;

		public static PhotoData CreateFromJSON(string jsonString) {

			return JsonUtility.FromJson<PhotoData> (jsonString);

		}

	}

	[System.Serializable]
	public class Item {


		public int id;
		public float lat;
		public float lng;
		public int elevation;

		public string title;

		public int distance;
		public int has_detail_page;
		public string webpage;
		public int rate;


	}












	/*
	public class MyRapper
	{
		public List<MyObject> objects;
	}


	[System.Serializable]
	public class MyObject {

		public string title;

	}

	public MyObject[] parseJsonToObject(string json) {

		MyObject[] Myobjects = JsonUtility.FromJson<MyRapper> (json);
		return Myobjects;
	}
	*/
		

}