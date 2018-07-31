using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
	Vector3 originalPosition;
	// Use this for initialization
	void Start () {
		originalPosition = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//called when teh ship or plane its it 
	private void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.CompareTag("ShipWall")) {
			transform.localPosition = originalPosition;
		}

	}
}
