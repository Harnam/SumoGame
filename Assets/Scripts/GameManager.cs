using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	public Button restart;
	public Button quit;
	bool chuk = false;

	// Use this for initialization
	void Start () {
		restart.gameObject.SetActive (false);
		quit.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!chuk) {
			if (!p1.activeSelf) {
				if (!p2.activeSelf) {
					//restart.gameObject.SetActive (true);
					//quit.gameObject.SetActive (true);
					//chuk = true;
					Scene scene = SceneManager.GetActiveScene ();
					SceneManager.LoadScene (scene.name);
				}
			}
		}
	}

	public void res(){
		Scene scene = SceneManager.GetActiveScene ();
		Debug.Log (scene);
		Debug.Log ("1");
		SceneManager.LoadScene (scene.name);
	}

	public void qui(){
		Application.Quit ();
	}
}
