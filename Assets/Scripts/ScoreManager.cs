using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public GameObject pl1;
	public GameObject pl2;
	public Text p1score;
	public Text p2score;
	int p1s;
	int p2s;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		p1score.text = PlayerPrefs.GetInt("BlueScore").ToString();
		p2score.text = PlayerPrefs.GetInt("RedScore").ToString();
		if (!pl1.activeSelf) {
			p2s++;
			PlayerPrefs.SetInt ("BlueScore", PlayerPrefs.GetInt("BlueScore")+1);
			//Scene scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene ("redwins");
		}
		if (!pl2.activeSelf) {
			p1s++;
			PlayerPrefs.SetInt ("RedScore", PlayerPrefs.GetInt("RedScore")+1);
			//Scene scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene ("bluewins");
		}
	}
}
