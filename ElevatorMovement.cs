using UnityEngine;
using System.Collections;

public class ElevatorMovement : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Debug.Log ("elevator movement script added to: " + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		//elevator moves up 
		if (Input.GetKey (KeyCode.Alpha1)) {
			transform.position += transform.up * Time.deltaTime * 10.0f;
		}
		//elevator moves down 
		if (Input.GetKey (KeyCode.Alpha3)) {
			transform.position -= transform.up * Time.deltaTime * 5.0f;
		}

	}
}
