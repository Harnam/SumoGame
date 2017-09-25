using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class rpcolorManager : MonoBehaviour {

	public void body(){
		SceneManager.LoadScene ("rp-body");
	}

	public void leftleg(){
		SceneManager.LoadScene ("rp-leftleg");
	}

	public void rightleg(){
		SceneManager.LoadScene ("rp-rightleg");
	}

	public void lefthand(){
		SceneManager.LoadScene ("rp-lefthand");
	}

	public void righthand(){
		SceneManager.LoadScene ("rp-righthand");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor");
	}

}
