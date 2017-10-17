using UnityEngine;
using System.Collections;

public class bluepl : MonoBehaviour {

	public GameObject player;
	public GameObject hat1;
	public GameObject hat2;
	public GameObject hat3;
	public GameObject hat4;
	public GameObject hat5;
	public GameObject hat6;
	private GameObject hattoins;
	private Vector3 posi;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		int pref = PlayerPrefs.GetInt("bluehat");
		if (pref == 0) {
			Debug.LogWarning ("No Hat for blue");
		} else {
			if (pref == 1) {
				hattoins = hat1;
			} else if (pref == 2) {
				hattoins = hat2;
			} else if (pref == 3) {
				hattoins = hat3;
			} else if (pref == 4) {
				hattoins = hat4;
			} else if (pref == 5) {
				hattoins = hat5;
			} else {
				hattoins = hat6;
			}
			posi = new Vector3 (player.gameObject.transform.position.x, player.gameObject.transform.position.y + 0.8f, player.gameObject.transform.position.z);
			Instantiate (hattoins, posi, Quaternion.identity, player.transform);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
