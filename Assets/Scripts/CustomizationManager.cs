using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CustomizationManager : MonoBehaviour {

	public void backbtn(){
		SceneManager.LoadScene ("mainmenu");
	}

	public void hatsbtn(){
		SceneManager.LoadScene ("customhat");
	}

	public void colorbtn(){
		SceneManager.LoadScene ("customcolor");
	}

}
