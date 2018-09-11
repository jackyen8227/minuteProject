using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
	//refs
	bool right_obj;
	bool pickedUp= false;


	//game Object 
	Sphere sphere;
	Cylinder cylinder;
	Tissuepaper tissuePaper;

	public GameObject videoPlayer;
	// Use this for initialization
	void Start () {
		GameObject Sphere = GameObject.Find ("Sphere");
		sphere = Sphere.GetComponent<Sphere> ();
//		right_obj = sphere.is_right_obj;

		GameObject Cylinder = GameObject.Find ("Cylinder");
		cylinder = Cylinder.GetComponent<Cylinder> ();
		//right_obj = cylinder.is_right_obj;

		GameObject TissuePaper = GameObject.Find ("Tissuepaper");
		tissuePaper = TissuePaper.GetComponent<Tissuepaper> ();
		right_obj = tissuePaper.is_right_obj;

		//two_right_obj = cylinder.is_right_obj;

		Debug.Log ("debug: " + right_obj );
			
	}
	
	// Update is called once per frame
	void Update () {
		if (!tissuePaper.gameObject.activeSelf) {
			pickedUp = true;
		}

		Debug.Log ("picked up: "+ pickedUp);
			
		if (pickedUp && right_obj) {
			Debug.Log ("picked up right object");
			videoPlayer.SetActive (true);
		} else {
			
		}
	}

	//check if the player get the right object or not
	void matching(bool is_right){
		
	
	}


}
