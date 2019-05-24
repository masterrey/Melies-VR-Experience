using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScreen : MonoBehaviour {
	public GameObject head;
	CharacterController crtl;
	float xhead;
	float ybody;
	// Use this for initialization
	void Start () {
		Input.compass.enabled = true;
		Input.location.Start();
		crtl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
		{
			crtl.SimpleMove(head.transform.forward);
		}
		/*
		Vector3 fixedAxis =
			new Vector3(Input.acceleration.x, Input.acceleration.y, -Input.acceleration.z);

		xhead = Mathf.Lerp(xhead, fixedAxis.z * 100, Time.deltaTime);

		head.transform.localRotation = Quaternion.Euler(Vector3.right * xhead);
		ybody = Mathf.LerpAngle(ybody, Input.compass.trueHeading, Time.deltaTime);
		transform.rotation = Quaternion.Euler(0, ybody, 0);
		*/
	}
}
