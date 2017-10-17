using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void quitgam(){
		Application.Quit ();
	}

	public void resetscore(){
		PlayerPrefs.SetInt ("BlueScore", 0);
		PlayerPrefs.SetInt ("RedScore", 0);
	}

	public void gamestart(){
		SceneManager.LoadScene ("Loading");
	}

	public void chgsetting(){
		SceneManager.LoadScene ("settings");
	}

	public void customization(){
		SceneManager.LoadScene ("Customization");
	}
}
