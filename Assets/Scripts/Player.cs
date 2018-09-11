using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Player : MonoBehaviour {
	
	//refs
	public float speed = 0.01f;
	public float rSpeed = 10000.0f;
	Rigidbody rigidbody;
	private NavMeshAgent agent;
	static Animator anim;


	//game object
	public Camera main;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		rigidbody = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		// r-theta plane
		float translation = Input.GetAxis ("Vertical")*speed;
		float rotation = Input.GetAxis ("Horizontal")*rSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0,0,translation);
		transform.Rotate (0, rotation, 0);
		if (translation != 0) {
			anim.SetBool ("isWalking", true);
		} else {
			anim.SetBool ("isWalking", false);
		}
		// x-y plane
//		float vtMove = Input.GetAxis ("Vertical");
//		float hrMove = Input.GetAxis ("Horizontal");
//		Vector3 movement = new Vector3 (hrMove * speed * Time.deltaTime, 0, vtMove * speed * Time.deltaTime);
//		rigidbody.MovePosition (transform.position + movement);
//		if (vtMove != 0 || hrMove !=0) {
//			anim.SetBool ("isWalking", true);
//		} else {
//			anim.SetBool ("isWalking", false);
//		}
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				Vector3 targetPoint = hit.point;
				agent.SetDestination(targetPoint);
				//transform.position = Vector3.Lerp (transform.position, targetPoint, 0.8f);
//				Debug.Log(Vector3.Distance(targetPoint,transform.position));
				}
		}

	}


}
