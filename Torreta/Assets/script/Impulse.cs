using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour {
	private Rigidbody rigidObjeto;
	// Use this for initialization
	public float impulso;
	void Start () {
		rigidObjeto=GetComponent<Rigidbody>();
		rigidObjeto.AddRelativeForce(Vector3.forward*impulso, ForceMode.Impulse);

	//	Destroy(this.gameObject,3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
