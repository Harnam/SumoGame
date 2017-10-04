using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class customhat : MonoBehaviour {

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
