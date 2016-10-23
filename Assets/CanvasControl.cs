using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour {

	public GameObject moviePanel;
	public GameObject servicePanel;
	public GameObject selectedmovie;
	public GameObject origmovie;
	public GameObject selectedservice;
	public GameObject origservice;
	public GameObject moviebottom;
	public GameObject servicebottom;
	public GameObject TVbutton;
	public Color pressedColor;

	 

	// Use this for initialization
	void Start () {

		moviePanel.SetActive (true);
		servicePanel.SetActive (false);
		selectedmovie.SetActive (true);
		origmovie.SetActive (false);
		selectedservice.SetActive (false);
		origservice.SetActive (true);
		moviebottom.SetActive (true);
		servicebottom.SetActive (false);

	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SwitchtoService(){

		moviePanel.SetActive (false);
		servicePanel.SetActive (true);
		selectedmovie.SetActive (false);
		origmovie.SetActive (true);
		selectedservice.SetActive (true);
		origservice.SetActive (false);
		moviebottom.SetActive (false);
		servicebottom.SetActive (true);

	}

	public void SwitchtoMovie(){

		moviePanel.SetActive (true);
		servicePanel.SetActive (false);
		selectedmovie.SetActive (true);
		origmovie.SetActive (false);
		selectedservice.SetActive (false);
		origservice.SetActive (true);
		moviebottom.SetActive (true);
		servicebottom.SetActive (false);

	}



}
