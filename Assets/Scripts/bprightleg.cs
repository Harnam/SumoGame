using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bprightleg : MonoBehaviour {

	public void bluebtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 1);
		Debug.Log ("WOW");
	}

	public void blackbtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 2);
		Debug.Log ("WOW");
	}

	public void cyanbtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 3);
		Debug.Log ("WOW");
	}

	public void graybtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 4);
		Debug.Log ("WOW");
	}
	public void greenbtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 5);
		Debug.Log ("WOW");
	}
	public void magentabtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 6);
		Debug.Log ("WOW");
	}
	public void redbtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 7);
	}

	public void whitebtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 8);
		Debug.Log ("WOW");
	}
	public void yellowbtn(){
		PlayerPrefs.SetInt ("bp-rightleg", 9);
		Debug.Log ("WOW");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor-bp");
	}

	public void rpbluebtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 1);
		Debug.Log ("WOW");
	}

	public void rpblackbtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 2);
		Debug.Log ("WOW");
	}

	public void rpcyanbtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 3);
		Debug.Log ("WOW");
	}

	public void rpgraybtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 4);
		Debug.Log ("WOW");
	}
	public void rpgreenbtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 5);
		Debug.Log ("WOW");
	}
	public void rpmagentabtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 6);
		Debug.Log ("WOW");
	}
	public void rpredbtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 7);
	}

	public void rpwhitebtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 8);
		Debug.Log ("WOW");
	}
	public void rpyellowbtn(){
		PlayerPrefs.SetInt ("rp-rightleg", 9);
		Debug.Log ("WOW");
	}

	public void rpbackbtn(){
		SceneManager.LoadScene ("customcolor-rp");
	}
}
