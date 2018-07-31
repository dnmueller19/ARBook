using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	public float xvalue, yvalue, zvalue;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//vector 3 take x,y,z directions
		transform.Translate(new Vector3(xvalue, yvalue, zvalue) * Time.deltaTime);
	}
}
