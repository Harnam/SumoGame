using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public static Audio instance;

	void Awake() {
		if (instance == null) {
			DontDestroyOnLoad (transform.gameObject);
			instance = this;
		} else {
			Destroy (transform.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
