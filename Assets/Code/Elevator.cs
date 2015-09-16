using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	 
	public Transform F1,F2,F3; 
	

	// Use this for initialization
	void Start () {
		//Debug.Log ("elevator movement script added to: " + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		//elevator moves up 
		

	}
	
	void OnTriggerStay(Collider other) 
	{ 
		if (Input.GetKey (KeyCode.Alpha1)) {
			transform.position = Vector3.MoveTowards(transform.position, F1.position, Time.deltaTime*10F);
			//transform.position += transform.up * Time.deltaTime * 10.0f;
		}
		
		if (Input.GetKey (KeyCode.Alpha2)) {
			transform.position = Vector3.MoveTowards(transform.position, F2.position, Time.deltaTime);
			//transform.position -= transform.up * Time.deltaTime * 5.0f;
		}
		//elevator moves down 
		if (Input.GetKey (KeyCode.Alpha3)) {
			transform.position = Vector3.MoveTowards(transform.position, F3.position, Time.deltaTime);
			//transform.position -= transform.up * Time.deltaTime * 5.0f;
		}
	}


}
