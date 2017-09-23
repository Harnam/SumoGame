using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerLose : MonoBehaviour {

	public Text text;
	bool isdead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider col){
		if (!isdead) {
			col.transform.parent.gameObject.SetActive (false);
			isdead = true;
		}
		if (isdead) {
			text.text = "YOU LOSE";
		}
	}
}
