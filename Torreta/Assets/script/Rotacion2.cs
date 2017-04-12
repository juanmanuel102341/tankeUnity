using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion2 : MonoBehaviour {
	public float velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q)){
			transform.Rotate(Vector3.up*Time.deltaTime*velocity,Space.World);	
		}else if(Input.GetKey(KeyCode.E)){
			transform.Rotate(Vector3.up*Time.deltaTime*velocity*-1,Space.World);	
		}	
	}
}
