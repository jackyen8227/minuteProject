using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trigger : MonoBehaviour {
	public Text triggerQuestion;
	public GameObject item;
	public GameObject time_text;

	private GameObject first_picked_item;


	//refs
	private string picked_item;
	int pickedNumber=0; //keep track of how many items you have picked
	public bool pickup_right_obj = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
