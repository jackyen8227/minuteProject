using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	int time_int = 60;
	public Text time_UI;
	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (time_int >= 0) {
			time_UI.text = ("" + time_int);
		}
		if (time_int < 0) {
			time_UI.text = ("use your brain motherfucker!");
		}




	}

	IEnumerator LoseTime(){
		while (true) {
			yield return new WaitForSeconds (1);
			time_int--;
	
	
		}
	}
}
