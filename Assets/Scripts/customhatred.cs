using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class customhatred : MonoBehaviour {

	void Start(){
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	public void bt1(){
		PlayerPrefs.SetInt ("redhat", 1);
	}

	public void bt2(){
		PlayerPrefs.SetInt ("redhat", 2);
	}

	public void bt3(){
		PlayerPrefs.SetInt ("redhat", 3);
	}

	public void bt4(){
		PlayerPrefs.SetInt ("redhat", 4);
	}

	public void bt5(){
		PlayerPrefs.SetInt ("redhat", 5);
	}

	public void bt6(){
		PlayerPrefs.SetInt ("redhat", 6);
	}

	public void back(){
		SceneManager.LoadScene ("customhat");
	}

	public void bbt1(){
		PlayerPrefs.SetInt ("bluehat", 1);
	}

	public void bbt2(){
		PlayerPrefs.SetInt ("bluehat", 2);
	}

	public void bbt3(){
		PlayerPrefs.SetInt ("bluehat", 3);
	}

	public void bbt4(){
		PlayerPrefs.SetInt ("bluehat", 4);
	}

	public void bbt5(){
		PlayerPrefs.SetInt ("bluehat", 5);
	}

	public void bbt6(){
		PlayerPrefs.SetInt ("bluehat", 6);
	}
}
