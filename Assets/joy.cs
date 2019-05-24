using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class joy : MonoBehaviour {
	public SpriteRenderer icon;
	public NavMeshAgent agent;
	float waiting = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		RaycastHit hit;
		icon.color = Color.white;
		
		if (Physics.Raycast(transform.position,transform.forward,out hit)){
			Debug.DrawLine(transform.position, hit.point);
			print(hit.collider.gameObject.name);
			icon.gameObject.transform.position = hit.point - transform.forward;
			icon.gameObject.transform.localScale =0.005f* Vector3.one * hit.distance;
			if (hit.collider.CompareTag("Interact"))
			{
				icon.color = Color.green;
				

				waiting -= Time.deltaTime;
				if (waiting<0)
				{
					//if (hit.collider.gameObject.layer.CompareTo("Icon")>0)
					{
						agent.SetDestination(hit.collider.transform.position);
					}
				}
			}
			else
			{
				waiting = 3;
			}
			
		}
	}
}
