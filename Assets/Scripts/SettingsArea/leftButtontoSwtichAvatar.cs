using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftButtontoSwtichAvatar : MonoBehaviour {

	public static int count = 3;
	public Sprite image0;
	public Sprite image1;
	public Sprite image2;
	public Sprite image3;
	private Sprite[] images;

	public Image imgAvatar;
	Image myImageComponent;

	public Button btnRight;

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button>().onClick.AddListener (changeAvatar); // it means I pressed the left side.
		myImageComponent = imgAvatar.GetComponent<Image> ();

		images = new Sprite[4];
		images [0] = image0;
		images [1] = image1;
		images [2] = image2;
		images [3] = image3;



	}
	
	// Update is called once per frame
	void Update () {
		btnRight.onClick.AddListener (clickRight);

	}
		
	void changeAvatar () {

		if (count > 0) {
			count -= 1;
			myImageComponent.sprite = images[count];

		}
	}

	void clickRight () {

		count = rightButtontoSwitchAvatar.count;

	}

}
