using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemName : MonoBehaviour {
	public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick(){

		string name = gameObject.GetComponent<Text> ().text;
		OrderCart.sharedInstance.appendOrder (name);

	}
}
