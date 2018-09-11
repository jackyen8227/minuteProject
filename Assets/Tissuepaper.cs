using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tissuepaper : MonoBehaviour {
	public bool is_right_obj;
	// Use this for initialization
	void Start () {
		if (transform.CompareTag ("right_object")) {
			is_right_obj = true;

		} else {
			is_right_obj = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
