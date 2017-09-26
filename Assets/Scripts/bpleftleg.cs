using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bpleftleg : MonoBehaviour {

	public void bluebtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 1);
		Debug.Log ("WOW");
	}

	public void blackbtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 2);
		Debug.Log ("WOW");
	}

	public void cyanbtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 3);
		Debug.Log ("WOW");
	}

	public void graybtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 4);
		Debug.Log ("WOW");
	}
	public void greenbtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 5);
		Debug.Log ("WOW");
	}
	public void magentabtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 6);
		Debug.Log ("WOW");
	}
	public void redbtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 7);
		Debug.Log ("WOW");
	}

	public void whitebtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 8);
		Debug.Log ("WOW");
	}
	public void yellowbtn(){
		PlayerPrefs.SetInt ("bp-leftleg", 9);
		Debug.Log ("WOW");
	}

	public void backbtn(){
		SceneManager.LoadScene ("customcolor-bp");
	}

	public void rpbluebtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 1);
		Debug.Log ("WOW");
	}

	public void rpblackbtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 2);
		Debug.Log ("WOW");
	}

	public void rpcyanbtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 3);
		Debug.Log ("WOW");
	}

	public void rpgraybtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 4);
		Debug.Log ("WOW");
	}
	public void rpgreenbtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 5);
		Debug.Log ("WOW");
	}
	public void rpmagentabtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 6);
		Debug.Log ("WOW");
	}
	public void rpredbtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 7);
	}

	public void rpwhitebtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 8);
		Debug.Log ("WOW");
	}
	public void rpyellowbtn(){
		PlayerPrefs.SetInt ("rp-leftleg", 9);
		Debug.Log ("WOW");
	}

	public void rpbackbtn(){
		SceneManager.LoadScene ("customcolor-rp");
	}
}
