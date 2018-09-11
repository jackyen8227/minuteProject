using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sphere : MonoBehaviour {
	public Text triggerQuestion;
	public GameObject item;
	public GameObject time_text; 
	public bool is_right_obj;

	// Use this for initialization
	void Start () {
		if (transform.CompareTag ("right_object")) {
			is_right_obj = true;
		
		} else {
			is_right_obj = false;
		}

	}


	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			triggerQuestion.text = "Do you want to pick up "+item.name +" ?\n"+"Yes/No? (press y/n)";

		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			triggerQuestion.text = " text ";
		}
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
