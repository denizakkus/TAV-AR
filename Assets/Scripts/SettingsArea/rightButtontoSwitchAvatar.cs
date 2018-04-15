using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightButtontoSwitchAvatar : MonoBehaviour {

	public static int count = 3;
	public Sprite image_0;
	public Sprite image_1;
	public Sprite image_2;
	public Sprite image_3;
	private Sprite[] images;

	public Image imgAvatar;
	Image myImageComponent;

	public Button btnLeft;

	// Use this for initialization
	void Start () {


		gameObject.GetComponent<Button>().onClick.AddListener (changeAvatar); // it means I pressed the left side.
		myImageComponent = imgAvatar.GetComponent<Image> ();

		images = new Sprite[4];
		images [0] = image_0;
		images [1] = image_1;
		images [2] = image_2;
		images [3] = image_3;



	}

	// Update is called once per frame
	void Update () {
		btnLeft.onClick.AddListener (clickLeft);
	}

	void changeAvatar () {

		if (count < 3) {
			count += 1;
			myImageComponent.sprite = images[count];
		}
	}

	void clickLeft () {

		count = leftButtontoSwtichAvatar.count;

	}
	
}
