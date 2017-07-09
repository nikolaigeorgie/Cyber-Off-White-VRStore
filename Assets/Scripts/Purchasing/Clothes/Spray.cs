
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using SimpleFirebaseUnity;
using SimpleFirebaseUnity.MiniJSON;

using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;

[System.Serializable]
public class SprayClothes{

	public string station;
	public string productName;
	public string color;
	public string size;
	public string quantity;
	public string totalPrice;
}

public class Spray : MonoBehaviour {

	public GameObject sizeSelection;
	public GameObject quantitySelection;
	public GameObject finalMessage;
	public GameObject purchaseOption;

	SprayClothes pastelleSweater = new SprayClothes();

	public static string sprayDetails;


	public void SizeButton()
	{
		pastelleSweater.productName = "Spray";
		pastelleSweater.color = "Grey";
		pastelleSweater.size = "small";	
		pastelleSweater.station = "3";

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);
	}

	public void sizeSmall() {
		pastelleSweater.productName = "Spray";
		pastelleSweater.color = "Grey";
		pastelleSweater.size = "Small";	
		//	pastelleSweater.station = "3";

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);

	}


	public void sizeMedium() {
		pastelleSweater.productName = "Spray";
		pastelleSweater.color = "Grey";
		pastelleSweater.size = "Medium";	

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);

	}


	public void sizeLarge() {
		pastelleSweater.productName = "Spray";
		pastelleSweater.color = "Grey";
		pastelleSweater.size = "Large";	
		pastelleSweater.station = "3";

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);

	}


	public void QuantityButton() {

		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);
	}


	public void quantityOne() {
		pastelleSweater.quantity = "1";
		pastelleSweater.totalPrice = "$3000";
		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);

		sprayDetails = JsonUtility.ToJson (pastelleSweater);
	}

	public void quantityTwo() {
		pastelleSweater.quantity = "2";
		pastelleSweater.totalPrice = "$3000";
		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);

		sprayDetails = JsonUtility.ToJson (pastelleSweater);
	}


	public void quantityThree() {
		pastelleSweater.quantity = "3";
		pastelleSweater.totalPrice = "$3000";
		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);

		sprayDetails = JsonUtility.ToJson (pastelleSweater);
	}



	public void PurchaseButton() {

		purchaseOption.SetActive (false);
		sizeSelection.SetActive (true);
	}

}
