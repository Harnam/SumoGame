using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {

	public Dropdown val;

	public void togglefullsc(){
		Screen.fullScreen = !Screen.fullScreen;
	}

	public void backbtn(){
		SceneManager.LoadScene ("mainmenu");
	}

	public void changeres(){
		if (val.value == 0) {
			Screen.SetResolution (1920, 1080, Screen.fullScreen);
		} else if (val.value == 1) {
			Screen.SetResolution (1366, 768, Screen.fullScreen);
		} else if (val.value == 2) {
			Screen.SetResolution (1280, 720, Screen.fullScreen);
		} else if (val.value == 3) {
			Screen.SetResolution (800, 600, Screen.fullScreen);
		} else {
			Screen.SetResolution (600, 480, Screen.fullScreen);
		}
	}

	public void quallvllow(){
		QualitySettings.SetQualityLevel (0);
	}

	public void quallvlmed(){
		QualitySettings.SetQualityLevel (3);
	}

	public void quallvlhigh(){
		QualitySettings.SetQualityLevel (5);
	}
}
