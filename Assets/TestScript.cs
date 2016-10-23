/*
Copyright 2015 Google Inc. All Rights Reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript : MonoBehaviour {

	public static TestScript sharedInstance;

	public int index = 0;

	IFirebase firebase;

	public Text temp;

	public void Clear(){

		temp.GetComponent<Text> ().text = "";

	}



	// Use this for initialization
	void Start () {
		TestScript.sharedInstance = this;
		TestScript.sharedInstance.index = 3;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void upload(){

		string source = temp.GetComponent<Text> ().text;
		string[] stringSeparators = new string[] {"\n"};
		var result = source.Split(stringSeparators, System.StringSplitOptions.None);
		temp.GetComponent<Text> ().text = "Sent Successfully!";

		foreach (string i in result){
			if (!i.Equals ("") && !i.Equals("\n")) {
				TestScript.sharedInstance.index += 1;
				string index = TestScript.sharedInstance.index.ToString ();
				TestScript.sharedInstance.firebase = Firebase.CreateNew ("https://cathay-pacific-e439a.firebaseio.com/");

				TestScript.sharedInstance.firebase.Child ("Services").Child (index).Child ("Seat").SetValue ("31J");
				TestScript.sharedInstance.firebase.Child ("Services").Child (index).Child ("Marco").SetValue ("No");
				TestScript.sharedInstance.firebase.Child ("Services").Child (index).Child ("Passenger").SetValue ("Samson");
				TestScript.sharedInstance.firebase.Child ("Services").Child (index).Child ("Item").SetValue (i);
			}
		}




	}

}
