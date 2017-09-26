using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bprighthand : MonoBehaviour {

	public void bluebtn(){
		PlayerPrefs.SetInt ("bp-righthand", 1);
		Debug.Log ("WOW");
	}

	public void blackbtn(){
		PlayerPrefs.SetInt ("bp-righthand", 2);
		Debug.Log ("WOW");
	}

	public void cyanbtn(){
		PlayerPrefs.SetInt ("bp-righthand", 3);
		Debug.Log ("WOW");
	}

	public void graybtn(){
		PlayerPrefs.SetInt ("bp-righthand", 4);
		Debug.Log ("WOW");
	}
	public void greenbtn(){
		PlayerPrefs.SetInt ("bp-righthand", 5);
		Debug.Log ("WOW");
	}
	public void magentabtn(){
		PlayerPrefs.SetInt ("bp-righthand", 6);
		Debug.Log ("WOW");
	}
	public void redbtn(){
		PlayerPrefs.SetInt ("bp-righthand", 7);
		Debug.Log ("WOW");
	}

	public void whitebtn(){
		PlayerPrefs.SetInt ("bp-righthand", 8);
		Debug.Log ("WOW");
	}
	public void yellowbtn(){
		PlayerPrefs.SetInt ("bp-righthand", 9);
		Debug.Log ("WOW");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor-bp");
	}

	public void rpbluebtn(){
		PlayerPrefs.SetInt ("rp-righthand", 1);
		Debug.Log ("WOW");
	}

	public void rpblackbtn(){
		PlayerPrefs.SetInt ("rp-righthand", 2);
		Debug.Log ("WOW");
	}

	public void rpcyanbtn(){
		PlayerPrefs.SetInt ("rp-righthand", 3);
		Debug.Log ("WOW");
	}

	public void rpgraybtn(){
		PlayerPrefs.SetInt ("rp-righthand", 4);
		Debug.Log ("WOW");
	}
	public void rpgreenbtn(){
		PlayerPrefs.SetInt ("rp-righthand", 5);
		Debug.Log ("WOW");
	}
	public void rpmagentabtn(){
		PlayerPrefs.SetInt ("rp-righthand", 6);
		Debug.Log ("WOW");
	}
	public void rpredbtn(){
		PlayerPrefs.SetInt ("rp-righthand", 7);
	}

	public void rpwhitebtn(){
		PlayerPrefs.SetInt ("rp-righthand", 8);
		Debug.Log ("WOW");
	}
	public void rpyellowbtn(){
		PlayerPrefs.SetInt ("rp-righthand", 9);
		Debug.Log ("WOW");
	}

	public void rpbackbtn(){
		SceneManager.LoadScene ("customcolor-rp");
	}

}
