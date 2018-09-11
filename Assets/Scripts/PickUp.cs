using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickUp : MonoBehaviour {
	public GameObject item;
	public Text triggerQuestion;
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
		CheckPlayerInput ();

		//get the picked up game object

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			triggerQuestion.text = "Do you want to pick up "+item.name +" ?\n"+"Yes/No? (press y/n)";
			picked_item = item.name;
			Debug.Log ("picked_item: " + picked_item);

		}
	}

	void CheckPlayerInput(){
		
		if (Input.GetKeyDown (KeyCode.Y)) {
			pickedNumber += 1;

			if (pickedNumber == 1) {
				item.SetActive (false);
				Debug.Log ("picked up item oh ya: " + picked_item);
			}

			triggerQuestion.text = "You have picked up the " + picked_item;
			time_text.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.N)) {
			
			triggerQuestion.text = "You can keep searching for items!";
		
		}


	
	
	}




}
