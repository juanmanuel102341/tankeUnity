using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour {
	private Rigidbody objRigid;
	public float velocity;
	public float velocityRotation;
	// Use this for initialization
	void Start () {
		//objRigid=GetComponent<Rigidbody>();


	}
	void Update(){
		if(Input.GetKey(KeyCode.A)){
		//	transform.Translate(Vector3.left*Time.deltaTime*velocity);
			transform.Rotate(Vector3.up*Time.deltaTime*-velocityRotation);
		}else if(Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.up*Time.deltaTime*velocityRotation);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward*Time.deltaTime*velocity);
		}else if(Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.back*Time.deltaTime*velocity);
		}


	}
	
	// Update is called once per frame

}
