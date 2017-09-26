using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bplefthand : MonoBehaviour {

	public void bluebtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 1);
		Debug.Log ("WOW");
	}

	public void blackbtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 2);
		Debug.Log ("WOW");
	}

	public void cyanbtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 3);
		Debug.Log ("WOW");
	}

	public void graybtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 4);
		Debug.Log ("WOW");
	}
	public void greenbtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 5);
		Debug.Log ("WOW");
	}
	public void magentabtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 6);
		Debug.Log ("WOW");
	}
	public void redbtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 7);
		Debug.Log ("WOW");
	}

	public void whitebtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 8);
		Debug.Log ("WOW");
	}
	public void yellowbtn(){
		PlayerPrefs.SetInt ("bp-lefthand", 9);
		Debug.Log ("WOW");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor-bp");
	}

	public void rpbluebtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 1);
		Debug.Log ("WOW");
	}

	public void rpblackbtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 2);
		Debug.Log ("WOW");
	}

	public void rpcyanbtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 3);
		Debug.Log ("WOW");
	}

	public void rpgraybtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 4);
		Debug.Log ("WOW");
	}
	public void rpgreenbtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 5);
		Debug.Log ("WOW");
	}
	public void rpmagentabtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 6);
		Debug.Log ("WOW");
	}
	public void rpredbtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 7);
	}

	public void rpwhitebtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 8);
		Debug.Log ("WOW");
	}
	public void rpyellowbtn(){
		PlayerPrefs.SetInt ("rp-lefthand", 9);
		Debug.Log ("WOW");
	}

	public void rpbackbtn(){
		SceneManager.LoadScene ("customcolor-rp");
	}
}
