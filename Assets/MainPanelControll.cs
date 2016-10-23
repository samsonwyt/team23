using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainPanelControll : MonoBehaviour {

	public Button GeneralButton;
	public Button JuiceButton;

	public Image first;
	public Image second;
	public Image third;
	public Image fourth;

	public Text firstname;
	public Text secondname;
	public Text thirdname;
	public Text fourthname;

	public Sprite juicefirst;
	public Sprite juicesecond;
	public Sprite juicethird;
	public Sprite juicefourth;

	public Sprite gfirst;
	public Sprite gsecond;
	public Sprite gthird;
	public Sprite gfourth;

	public Sprite juice2first;
	public Sprite juice2second;
	public Sprite juice2third;
	public Sprite juice2fourth;

	public GameObject gbutton;
	public GameObject gselectedbutton;
	public GameObject jbutton;
	public GameObject jselectedbutton;

	public GameObject left;
	public GameObject right;

	public GameObject fourthobj;

	// Use this for initialization
	void Start () {

		gselectedbutton.SetActive (true);
		gbutton.SetActive (false);
		jbutton.SetActive (true);
		jselectedbutton.SetActive (false);
		left.SetActive (false);
		right.SetActive (false);

		fourthobj.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PressedJuice(){
		first.sprite = juicefirst;
		second.sprite = juicesecond;
		third.sprite = juicethird;
		fourth.sprite = juicefourth;

		firstname.text = "Mango";
		secondname.text = "Lemon";
		thirdname.text = "Tomato";
		fourthname.text = "Apple";

		gselectedbutton.SetActive (false);
		gbutton.SetActive (true);
		jbutton.SetActive (false);
		jselectedbutton.SetActive (true);
		right.SetActive (true);

		fourthobj.SetActive (true);


	}

	public void PressedGeneral(){
		first.sprite = gfirst;
		second.sprite = gsecond;
		third.sprite = gthird;
		fourth.sprite = gfourth;

		firstname.text = "Water";
		secondname.text = "Coffee";
		thirdname.text = "Tea";
		fourthname.text = "Coconut Water";

		gselectedbutton.SetActive (true);
		gbutton.SetActive (false);
		jbutton.SetActive (true);
		jselectedbutton.SetActive (false);

		left.SetActive (false);
		right.SetActive (false);

		fourthobj.SetActive (true);
	}

	public void PressedRight(){
		first.sprite = juice2first;
		second.sprite = juice2second;
		third.sprite = juice2third;
		fourth.sprite = juice2fourth;

		firstname.text = "Watermelon";
		secondname.text = "Orange";
		thirdname.text = "Guava";
		fourthname.text = "";

		right.SetActive (false);
		left.SetActive (true);

		fourthobj.SetActive (false);

	}

	public void PressedLeft(){

		first.sprite = juicefirst;
		second.sprite = juicesecond;
		third.sprite = juicethird;
		fourth.sprite = juicefourth;

		firstname.text = "Mango";
		secondname.text = "Lemon";
		thirdname.text = "Tomato";
		fourthname.text = "Apple";

		right.SetActive (true);
		left.SetActive (false);
		fourthobj.SetActive (true);

	}


}
