using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 && (Input.GetTouch (0).phase == TouchPhase.Began)) {//If we've JUST tapped
			
			Ray raycast = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			RaycastHit raycastHit;

			if (Physics.Raycast (raycast, out raycastHit)) {
			
				Debug.Log ("You've tapped something");
			}

		
		}

	}
}
