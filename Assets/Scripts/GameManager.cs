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
	public Button gotomain;
	bool ispaused = false;
	public RawImage fightimg;
	public Text txt1;
	public Text txt2;
	public Text txt3;
	bool isload = false;
	public GameObject redcon;
	public GameObject bluecon;

	// Use this for initialization
	void Start () {
		redcon.gameObject.SetActive (true);
		bluecon.gameObject.SetActive (true);
		restart.gameObject.SetActive (false);
		quit.gameObject.SetActive (false);
		quitgame.gameObject.SetActive (false);
		unpause.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		gotomain.gameObject.SetActive (false);
		bg.gameObject.SetActive (false);
		Cursor.visible = false;
		p1.gameObject.GetComponent<PlayerMovement> ().enabled = false;
		p2.gameObject.GetComponent<PlayerMovement> ().enabled = false;
		txt2.gameObject.SetActive (false);
		txt1.gameObject.SetActive (false);
		fightimg.gameObject.SetActive (false);
		Destroy (txt3, 1);
		Destroy (txt2, 2);
		Destroy (txt1, 3);
		Destroy (fightimg, 4);
		StartCoroutine(playerenable());
		StartCoroutine(txt1enable());
		StartCoroutine(txt2enable());
		StartCoroutine(imgenable());
		Screen.orientation = ScreenOrientation.LandscapeLeft;
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
		if(isload){
			if (Input.GetKeyDown (KeyCode.Escape)) {
				Debug.Log ("Key Up");
				if (!ispaused) {
					quitgame.gameObject.SetActive (true);
					unpause.gameObject.SetActive (true);
					reset.gameObject.SetActive (true);
					gotomain.gameObject.SetActive (true);
					bg.gameObject.SetActive (true);
					p1.gameObject.GetComponent<PlayerMovement> ().enabled = false;
					p2.gameObject.GetComponent<PlayerMovement> ().enabled = false;
					redcon.gameObject.SetActive (false);
					bluecon.gameObject.SetActive (false);
					ispaused = true;
					Cursor.visible = true;
				} else if (ispaused) {
					quitgame.gameObject.SetActive (false);
					unpause.gameObject.SetActive (false);
					reset.gameObject.SetActive (false);
					bg.gameObject.SetActive (false);
					gotomain.gameObject.SetActive (false);
					p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
					p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
					redcon.gameObject.SetActive (true);
					bluecon.gameObject.SetActive (true);
					ispaused = false;
					Cursor.visible = false;
				} else {
					Debug.Log ("Noob");
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

	public void unpau(){
		quitgame.gameObject.SetActive (false);
		unpause.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		bg.gameObject.SetActive (false);
		gotomain.gameObject.SetActive (false);
		p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		redcon.gameObject.SetActive (true);
		bluecon.gameObject.SetActive (true);
		ispaused = false;
		Cursor.visible = false;
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

	public void mainmen(){
		SceneManager.LoadScene ("mainmenu");
	}

	IEnumerator playerenable(){
		yield return new WaitForSeconds(4);
		p1.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		p2.gameObject.GetComponent<PlayerMovement> ().enabled = true;
		p1.gameObject.GetComponent<PlayerMovement> ().bluework = true;
		Debug.Log ("START");
		isload = true;
	}

	IEnumerator txt2enable(){
		yield return new WaitForSeconds(1);
		txt2.gameObject.SetActive (true);
	}

	IEnumerator txt1enable(){
		yield return new WaitForSeconds(2);
		txt1.gameObject.SetActive (true);
	}

	IEnumerator imgenable(){
		yield return new WaitForSeconds(3);
		fightimg.gameObject.SetActive (true);
	}

}
