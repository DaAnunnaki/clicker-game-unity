using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {

	// Game panel objects
	public Button doughButton, ovenButton, cookieButton;
	public Text cookieText, doughText;
	public int doughAmount, cookieAmount;

	// Common variables
	public int ovenPrice = 12;

	// Use this for initialization
	void Start () {
		ovenButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		// display gained number of strokes
		cookieText.text = cookieAmount + " COOKIES";
		doughText.text = doughAmount + " DOUGH";

		DoYouHaveEnoughStrokesToBuySmth();
	}

	public void makeCookie()
	{
		doughAmount += 1;
	}

	public void bakeCookie()
	{
		cookieAmount += 12;
	}

	public void eatCookie()
	{
		cookieAmount -= 1;
	}

	// public void can_use_oven()
	// {
	// 	oven.gameObject.SetActive (true);
	// }

	void DoYouHaveEnoughStrokesToBuySmth()
	{
		if (doughAmount >= ovenPrice)
			ovenButton.interactable = false;
	}
  
}
