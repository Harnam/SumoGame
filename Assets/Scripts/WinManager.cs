using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour {

	public void Start(){
		Cursor.visible = true;
	}

	public void play(){
		SceneManager.LoadScene ("Loading");
	}

	public void mainenu(){
		SceneManager.LoadScene ("mainmenu");
	}
}