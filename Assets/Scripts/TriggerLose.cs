using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerLose : MonoBehaviour {

	public Text text;
	//bool isdead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider col){
		if (col.tag == "player1") {
			text.text = "RED WINS! BLUE LOSES!";
			return;
		}
		if (col.tag == "player2") {
			text.text = "BLUE WINS! RED LOSES!";
			return;
		}
		col.transform.parent.gameObject.SetActive (false);
	}
}
