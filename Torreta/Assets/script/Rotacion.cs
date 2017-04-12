using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {
	private Rigidbody rigidObjeto;

	//	private Transform transform_objeto;
	// Use this for initialization
	public float velocity=0.0f;
	private int direccion=1;
	private bool limite=false;
	void Start () {
		rigidObjeto=GetComponent<Rigidbody>();
		//transform=GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		print("rot "+rigidObjeto.rotation.z);
		print("rot transfom "+transform.rotation.eulerAngles.z);
		if(Input.GetKey(KeyCode.RightArrow)&&rigidObjeto.rotation.eulerAngles.z<355.0f){
			rigidObjeto.freezeRotation=false;
			print("derecha");
			direccion=1;
			rigidObjeto.AddRelativeTorque(Vector3.forward*velocity*Time.deltaTime*direccion);


		}else if(Input.GetKey(KeyCode.LeftArrow)&&rigidObjeto.rotation.eulerAngles.z>264.0f){
			limite=false;
			rigidObjeto.freezeRotation=false;
			direccion=-1;
			rigidObjeto.AddRelativeTorque(Vector3.forward*velocity*Time.deltaTime*direccion);
			print("izquierda");
		}else {
			if(rigidObjeto.rotation.z>=-0.4f){
				limite=true;
			}
			print("fuera");
			rigidObjeto.freezeRotation=true;

		}
	

	}

}
