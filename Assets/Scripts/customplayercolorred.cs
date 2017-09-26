using UnityEngine;
using System.Collections;

public class customplayercolorred : MonoBehaviour {

	public GameObject p1;
	Color righthand;
	GameObject rightupperhand;
	GameObject rightlowerhand;
	Color lefthand;
	GameObject leftupperhand;
	GameObject leftlowerhand;
	Color rightleg;
	GameObject rightupperleg;
	GameObject rightlowerleg;
	Color leftleg;
	GameObject leftupperleg;
	GameObject leftlowerleg;

	// Use this for initialization
	void Start () {
		rightupperhand = p1.transform.Find("RightUpperHand").gameObject;
		rightlowerhand = p1.transform.Find("RightLowerHand").gameObject;
		rightupperleg = p1.transform.Find("RightUpperLeg").gameObject;
		rightlowerleg = p1.transform.Find("RightLowerLeg").gameObject;
		leftupperhand = p1.transform.Find("LeftUpperHand").gameObject;
		leftlowerhand = p1.transform.Find("LeftLowerHand").gameObject;
		leftupperleg = p1.transform.Find("LeftUpperLeg").gameObject;
		leftlowerleg = p1.transform.Find("LeftLowerLeg").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("rp-righthand") == 1) {
			righthand = Color.blue;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 2) {
			righthand = Color.black;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 3) {
			righthand = Color.cyan;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 4) {
			righthand = Color.gray;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 5) {
			righthand = Color.green;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 6) {
			righthand = Color.magenta;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 7) {
			righthand = Color.red;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 8) {
			righthand = Color.white;
		} else if (PlayerPrefs.GetInt ("rp-righthand") == 9) {
			righthand = Color.yellow;
		} else {
			righthand = Color.white;
		}
		rightlowerhand.GetComponent<Renderer> ().material.color = righthand;
		rightupperhand.GetComponent<Renderer> ().material.color = righthand;
		if (PlayerPrefs.GetInt ("rp-rightleg") == 1) {
			rightleg = Color.blue;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 2) {
			rightleg = Color.black;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 3) {
			rightleg = Color.cyan;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 4) {
			rightleg = Color.gray;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 5) {
			rightleg = Color.green;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 6) {
			rightleg = Color.magenta;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 7) {
			rightleg = Color.red;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 8) {
			rightleg = Color.white;
		} else if (PlayerPrefs.GetInt ("rp-rightleg") == 9) {
			rightleg = Color.yellow;
		} else {
			rightleg = Color.white;
		}
		rightlowerleg.GetComponent<Renderer> ().material.color = rightleg;
		rightupperleg.GetComponent<Renderer> ().material.color = rightleg;
		if (PlayerPrefs.GetInt ("rp-lefthand") == 1) {
			lefthand = Color.blue;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 2) {
			lefthand = Color.black;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 3) {
			lefthand = Color.cyan;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 4) {
			lefthand = Color.gray;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 5) {
			lefthand = Color.green;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 6) {
			lefthand = Color.magenta;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 7) {
			lefthand = Color.red;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 8) {
			lefthand = Color.white;
		} else if (PlayerPrefs.GetInt ("rp-lefthand") == 9) {
			lefthand = Color.yellow;
		} else {
			lefthand = Color.white;
		}
		leftlowerhand.GetComponent<Renderer> ().material.color = lefthand;
		leftupperhand.GetComponent<Renderer> ().material.color = lefthand;
		if (PlayerPrefs.GetInt ("rp-leftleg") == 1) {
			leftleg = Color.blue;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 2) {
			leftleg = Color.black;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 3) {
			leftleg = Color.cyan;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 4) {
			leftleg = Color.gray;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 5) {
			leftleg = Color.green;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 6) {
			leftleg = Color.magenta;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 7) {
			leftleg = Color.red;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 8) {
			leftleg = Color.white;
		} else if (PlayerPrefs.GetInt ("rp-leftleg") == 9) {
			leftleg = Color.yellow;
		} else {
			leftleg = Color.white;
		}
		leftlowerleg.GetComponent<Renderer> ().material.color = leftleg;
		leftupperleg.GetComponent<Renderer> ().material.color = leftleg;
	}
}
