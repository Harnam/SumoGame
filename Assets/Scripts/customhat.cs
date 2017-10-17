using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class customhat : MonoBehaviour {

	void Start(){
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	public void redpl(){
		SceneManager.LoadScene ("customhatred");
	}

	public void bluepl(){
		SceneManager.LoadScene ("customhatblue");
	}

	public void back(){
		SceneManager.LoadScene ("Customization");
	}
}
