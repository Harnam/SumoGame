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
	public Button quitgame;
	public Button unpause;
	public Button reset;
	public Image bg;
	bool ispaused = false;

	// Use this for initialization
	void Start () {
		restart.gameObject.SetActive (false);
		quit.gameObject.SetActive (false);
		quitgame.gameObject.SetActive (false);
		unpause.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		bg.gameObject.SetActive (false);
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
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log ("Key Up");
			if (!ispaused) {
				quitgame.gameObject.SetActive (true);
				unpause.gameObject.SetActive (true);
				reset.gameObject.SetActive (true);
				bg.gameObject.SetActive (true);
				p1.gameObject.GetComponent<PlayerMovement> ().enabled = false;
				p2.gameObject.GetComponent<PlayerMovement> ().enabled = false;
				ispaused = true;
			} else if (ispaused) {
				quitgame.gameObject.SetActive (false);
				unpause.gameObject.SetActive (false);
				reset.gameObject.SetActive (false);
				bg.gameObject.SetActive (false);
				p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
				p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
				ispaused = false;
			} else {
				Debug.Log("Noob");
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

	public void unpau(){
		quitgame.gameObject.SetActive (false);
		unpause.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		bg.gameObject.SetActive (false);
		p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		ispaused = false;
	}

	public void resetscore(){
		PlayerPrefs.SetInt ("BlueScore", 0);
		PlayerPrefs.SetInt ("RedScore", 0);
		quitgame.gameObject.SetActive (false);
		unpause.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		bg.gameObject.SetActive (false);
		Scene scene = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (scene.name);
		p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		ispaused = false;
	}

	public void quigame(){
		Application.Quit ();
	}
}
