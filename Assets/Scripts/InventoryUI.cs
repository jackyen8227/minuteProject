using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {
	public Sprite [] sprites;
	public Image icon;
	public Image icon2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AddItem (sprites [0]);
	}

	public void AddItem(Sprite sprite){
		icon.sprite = sprite;
	}
}
