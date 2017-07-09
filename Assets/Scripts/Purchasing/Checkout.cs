
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using SimpleFirebaseUnity;
using SimpleFirebaseUnity.MiniJSON;

using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;

public class CustomerNumber{

	public string customerId;

}

public class Checkout : MonoBehaviour {


	public GameObject checkoutPrompt;
	public GameObject finalPrompt;

	System.Guid myGUID = System.Guid.NewGuid();



	public static string rxsRedPurchased;
	public static string rxsBluePurchased;
	public static string rxsGreenPurchased;
	public static string rxsBlackPurchased;

	public static string pastelleYellowPurchased;
	public static string pastelleRedPurchased;
	public static string pastelleTigerPurchased;
	public static string sprayPaintIanPurchased;
	CustomerNumber customerNumber = new CustomerNumber ();

	public static string customerNumberDigit;



	public void checkedOUT(){

		checkoutPrompt.SetActive (false);
		finalPrompt.SetActive(true);
		StartCoroutine (checkoutCompleted ());

	}

	void start() {

		StartCoroutine (checkoutCompleted ());

	}

	IEnumerator checkoutCompleted() {

		rxsRedPurchased = RedPurchase.rxsRedShoeDetails;
		rxsBlackPurchased = BlackPurchase.rxsBlackShoeDetails;
		rxsGreenPurchased = GreenPurchase.rxsGreenShoeDetails;
		rxsBluePurchased = BluePurchase.rxsBlueShoeDetails;

		pastelleYellowPurchased = PastYellow.pastelleYellowDetails;
		pastelleRedPurchased = PastRed.pastelleRedDetails;
		pastelleTigerPurchased = PastTiger.pastelleTigerDetails;
		sprayPaintIanPurchased = Spray.sprayDetails;


		//		Firebase firebase = Firebase.CreateNew ("fir-test-884fd.firebaseio.com");
		Firebase firebase = Firebase.CreateNew ("cybershop-f4213.firebaseio.com");
	
		FirebaseQueue firebaseQueue = new FirebaseQueue();

		customerNumber.customerId = System.Guid.NewGuid ().ToString ();
		customerNumberDigit = JsonUtility.ToJson (customerNumber);

		//firebaseQueue.AddQueuePush(firebase.Child("order/customer", true), secondDetails + newDetails, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/CustomerId", true), customerNumberDigit, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/RedShoe", true), rxsRedPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/BlueShoe", true), rxsBluePurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/GreenShoe", true), rxsGreenPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/BlackShoe", true), rxsBlackPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/YellowPastelle", true), pastelleYellowPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/RedPastelle", true), pastelleRedPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/TigerPastelle", true), pastelleTigerPurchased, true);
		firebaseQueue.AddQueuePush(firebase.Child("customers/" + myGUID + "/SprayPaintedIan", true), sprayPaintIanPurchased, true);

		print ("WORKS");


		yield return new WaitForSeconds (15f);

		yield return null;

//		checkoutPrompt.SetActive (false);
//		finalPrompt.SetActive(true);

	}


}
