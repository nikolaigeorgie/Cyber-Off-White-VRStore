
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
public class PastRedClothes{


	public string station;
	public string productName;
	public string color;
	public string size;
	public string quantity;
	public string totalPrice;
}


public class PastRed : MonoBehaviour {


	public GameObject sizeSelection;
	public GameObject quantitySelection;
	public GameObject finalMessage;
	public GameObject purchaseOption;


	PastRedClothes pastelleSweater = new PastRedClothes();

	public static string pastelleRedDetails;


	public void SizeButton()
	{
		pastelleSweater.productName = "Pastelle";
		pastelleSweater.color = "Red";
		pastelleSweater.size = "small";	
		pastelleSweater.station = "3";

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);
	}

	public void sizeSmall() {
		pastelleSweater.productName = "Pastelle";
		pastelleSweater.color = "Red";
		pastelleSweater.size = "Small";	
		//	pastelleSweater.station = "3";

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);

	}


	public void sizeMedium() {
		pastelleSweater.productName = "Pastelle";
		pastelleSweater.color = "Red";
		pastelleSweater.size = "Medium";	

		sizeSelection.SetActive (false);
		quantitySelection.SetActive(true);

	}


	public void sizeLarge() {
		pastelleSweater.productName = "Pastelle";
		pastelleSweater.color = "Red";
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

		pastelleRedDetails = JsonUtility.ToJson (pastelleSweater);
	}

	public void quantityTwo() {
		pastelleSweater.quantity = "2";
		pastelleSweater.totalPrice = "$3000";
		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);

		pastelleRedDetails = JsonUtility.ToJson (pastelleSweater);
	}


	public void quantityThree() {
		pastelleSweater.quantity = "3";
		pastelleSweater.totalPrice = "$3000";
		quantitySelection.SetActive (false);
		finalMessage.SetActive (true);

		pastelleRedDetails = JsonUtility.ToJson (pastelleSweater);
	}



	public void PurchaseButton() {

		purchaseOption.SetActive (false);
		sizeSelection.SetActive (true);
	}

}
