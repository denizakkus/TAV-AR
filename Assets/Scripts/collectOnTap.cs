using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectOnTap : MonoBehaviour {


	public ParticleSystem particle;
	public GameObject player;
	public int scoreIncrement=200;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		foreach (Touch touch in Input.touches) {

			Ray ray = Camera.main.ScreenPointToRay (touch.position);	

			if (Physics.Raycast(ray,out hit))
			if (hit.transform.gameObject.name.StartsWith ("it_")) {

				if (!Collection.collection.Contains ("md_"+hit.collider.gameObject.name.Substring(3))) {
					Collection.collection.Add ("md_"+hit.collider.gameObject.name.Substring(3));
					PlayerVariables.score += scoreIncrement;
				}


				hit.collider.gameObject.SetActive(false);

			}

		}


		Vector3 mousePosFar = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
		Vector3 mousePosNear = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
		Vector3 mousePosF = Camera.main.ScreenToWorldPoint (mousePosFar);
		Vector3 mousePosN = Camera.main.ScreenToWorldPoint (mousePosNear);
		Debug.DrawRay (mousePosN,mousePosF-mousePosN,Color.green);


		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hit,Mathf.Infinity)) {
				if (hit.collider.gameObject.name.StartsWith ("it_")) {

						if (!Collection.collection.Contains ("md_"+hit.collider.gameObject.name.Substring(3)))
						Collection.collection.Add("md_"+hit.collider.gameObject.name.Substring(3));

					PlayerVariables.score += scoreIncrement;
					Debug.Log (hit.collider.name);
					hit.collider.gameObject.SetActive (false);
				}
			}
		}

	}

}
