using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OrderCart : MonoBehaviour {

	public static OrderCart sharedInstance;
	public GameObject text;

	// Use this for initialization
	void Start () {
		sharedInstance = this;
//		Text[] temp = OrderCart.sharedInstance.gameObject.GetComponentsInChildren<Text> ();
//		for (int i = 0; i < temp.Length; i++) {
//			if (temp [i].gameObject.name == "Text")
//				OrderCart.sharedInstance.text = temp [i].gameObject;
//		}
//		Text[] inner = OrderCart.sharedInstance.gameObject.GetComponentsInChildren<Text> ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void appendOrder(string name){
//		Debug.Log (name);
		if (OrderCart.sharedInstance.text.GetComponent<Text>().text.Equals("Sent Successfully!")) {
			OrderCart.sharedInstance.text.GetComponent<Text> ().text = name+ "\n";
		}
		if (!OrderCart.sharedInstance.text.GetComponent<Text>().text.Contains(name)) {
			OrderCart.sharedInstance.text.GetComponent<Text>().text = OrderCart.sharedInstance.text.GetComponent<Text>().text+ name + "\n";

		}

	}
}
