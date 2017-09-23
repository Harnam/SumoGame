using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int valueforce;
	public Rigidbody rb;
	public int defaultcon;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (defaultcon == 0) {
			if (Input.GetKey("up")){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.05f);
			}
			if (Input.GetKey("down")){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 0.05f);
			}
			if (Input.GetKey("left")){
				transform.position = new Vector3 (transform.position.x - 0.05f, transform.position.y, transform.position.z);
			}
			if (Input.GetKey("right")){
				transform.position = new Vector3 (transform.position.x + 0.05f, transform.position.y, transform.position.z );
			}
		}
		if (defaultcon == 1) {
			if (Input.GetKey(KeyCode.W)){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.05f);
			}
			if (Input.GetKey(KeyCode.S)){
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 0.05f);
			}
			if (Input.GetKey(KeyCode.A)){
				transform.position = new Vector3 (transform.position.x - 0.05f, transform.position.y, transform.position.z);
			}
			if (Input.GetKey(KeyCode.D)){
				transform.position = new Vector3 (transform.position.x + 0.05f, transform.position.y, transform.position.z );
			}
		}
	}
}
