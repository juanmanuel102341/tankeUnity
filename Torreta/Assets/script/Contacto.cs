using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contacto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnCollisionEnter(Collision c){
		
		if(c.gameObject.tag=="piso"){
			print("contacto piso");
		}else if(c.gameObject.tag=="player2"){
			print("contacto player2");
		}
	}
}
