using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bpcolorManager : MonoBehaviour {

	public void body(){
		SceneManager.LoadScene ("bp-body");
	}

	public void leftleg(){
		SceneManager.LoadScene ("bp-leftleg");
	}

	public void rightleg(){
		SceneManager.LoadScene ("bp-rightleg");
	}

	public void lefthand(){
		SceneManager.LoadScene ("bp-lefthand");
	}

	public void righthand(){
		SceneManager.LoadScene ("bp-righthand");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor");
	}

}
