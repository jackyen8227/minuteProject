using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastTest : MonoBehaviour {
	public float maxRayDistance = 25;
	public GameObject window;
	public float force = 0.2f;
	private Rigidbody rb;
	Vector3 shootDirection;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		shootDirection = window.transform.position - transform.position;
	}

	void FixedUpdate()
	{
		
		//Ray ray = new Ray (transform.position, shootDirection);
		//RaycastHit hit;

		//Debug.DrawLine (transform.position, transform.position + Vector3.left * maxRayDistance, Color.red);

		rb.AddForce(shootDirection * force);

		/*if (Physics.Raycast (ray, out hit, maxRayDistance)) {
			Debug.Log (hit.collider.gameObject.name);
		
		}*/
	}
}
