using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CustomizationColorManager : MonoBehaviour {

	public void backbtn(){
		SceneManager.LoadScene ("Customization");
	}

	public void blueplayerbtn(){
		SceneManager.LoadScene ("customcolor-bp");
	}

	public void redplayerbtn(){
		SceneManager.LoadScene ("customcolor-rp");
	}

}
