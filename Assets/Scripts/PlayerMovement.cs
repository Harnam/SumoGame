﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour{

	public int valueforce;
	public Rigidbody rb;
	public int defaultcon;
	public float speedval;
	float speed;
	public bool bluework = false;

	public void bluemoveforward(){
		if (bluework) {
			transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		}
	}

	public void redmoveforward(){
		transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		Debug.Log ("Red Up");
	}

	public void redmovedown(){
		transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
	}

	public void redmoveleft(){
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + speed);
	}

	public void redmoveright(){
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed );
	}

	public void bluemovedown(){
		if (bluework) {
			transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
		}
	}

	public void bluemoveleft(){
		if (bluework) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + speed);
		}
	}

	public void bluemoveright(){
		if (bluework) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed);
		}
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		speed = speedval * Time.deltaTime * 0.01f;
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		if (defaultcon == 0) {
			if (Input.GetKey("up")){
				transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
			}
			if (Input.GetKey("down")){
				transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
			}
			if (Input.GetKey("left")){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + speed);
			}
			if (Input.GetKey("right")){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed );
			}
		}
		if (defaultcon == 1) {
			if (Input.GetKey(KeyCode.W)){
				transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
			}
			if (Input.GetKey(KeyCode.S)){
				transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z );
			}
			if (Input.GetKey(KeyCode.A)){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + speed);
			}
			if (Input.GetKey(KeyCode.D)){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed);
			}
		}
	}
}
