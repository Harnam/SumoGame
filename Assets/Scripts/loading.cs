using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		SceneManager.LoadSceneAsync ("Main");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, speed * Time.deltaTime);
	}
}
