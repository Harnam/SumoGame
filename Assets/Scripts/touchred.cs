using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class touchred : MonoBehaviour {

	public PlayerMovement move;
	float leftright;
	float updown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		leftright = CrossPlatformInputManager.GetAxis ("Horizontal");
		if (leftright == 1) {
			RedRight();
		} else if (leftright == -1) {
			RedLeft ();
		} else {
			Debug.Log ("OOO");
		}
		updown = CrossPlatformInputManager.GetAxis ("Vertical");
		if (updown == 1) {
			RedUP();
		} else if (updown == -1) {
			RedDown ();
		} else {
			Debug.Log (updown);
			return;
		}
		if (CrossPlatformInputManager.GetButtonDown ("RedUP")) {
			RedUP ();
		}
		if (CrossPlatformInputManager.GetButtonDown ("RedRight")) {
			RedRight ();
		}
		if (CrossPlatformInputManager.GetButtonDown ("RedLeft")) {
			RedLeft ();
		}
		if (CrossPlatformInputManager.GetButtonDown ("RedDown")) {
			RedDown ();
		}
	}

	void RedUP(){
		Debug.Log ("Red Up");
		move.redmoveforward ();
	}
	void RedDown(){
		Debug.Log ("Red down");
		move.redmovedown ();
	}
	void RedLeft(){
		Debug.Log ("Red left");
		move.redmoveleft ();
	}
	void RedRight(){
		Debug.Log ("Red right");
		move.redmoveright ();
	}
}
