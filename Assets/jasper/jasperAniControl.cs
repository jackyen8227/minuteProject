using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jasperAniControl : MonoBehaviour {
	static Animator anim;
	public float speed = 10.0F;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) 
		{
			anim.SetTrigger ("isWalking");
		}
	}
}
