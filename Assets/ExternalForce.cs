using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalForce : MonoBehaviour {
	Rigidbody rdb;
	// Use this for initialization
	void Start () {
		rdb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate()
	{
		Vector3 fixedAxis = 
			new Vector3(Input.acceleration.x, Input.acceleration.y, -Input.acceleration.z);
		rdb.AddForce(fixedAxis);
	}
}
