using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	 
	public Transform F1,F2,F3; 
	public bool floor1, floor2, floor3 = false; 

	// Use this for initialization
	void Start () {
		//Debug.Log ("elevator movement script added to: " + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		//elevator moves up 
		if(floor1)
		{ 
			transform.position = Vector3.MoveTowards(transform.position, F1.position, Time.deltaTime*10F);
			
		}
		if(floor2)
		{ 
			transform.position = Vector3.MoveTowards(transform.position, F2.position, Time.deltaTime*10F);
			
		}
		if(floor3)
		{ 
			transform.position = Vector3.MoveTowards(transform.position, F3.position, Time.deltaTime*10F);
			
		}

	}
	
	void OnTriggerStay(Collider other) 
	{ 
		if (Input.GetKey (KeyCode.Alpha1)) {
			floor1 = true;
			floor2 = false; 
			floor3 = false; 
			//transform.position += transform.up * Time.deltaTime * 10.0f;
		}
		
		if (Input.GetKey (KeyCode.Alpha2)) {
			floor2 = true; 
			floor1 = false; 
			floor3 = false; 
			//transform.position -= transform.up * Time.deltaTime * 5.0f;
		}
		//elevator moves down 
		if (Input.GetKey (KeyCode.Alpha3)) {
			floor3 = true; 
			floor1 = false; 
			floor2 = false; 
			//transform.position -= transform.up * Time.deltaTime * 5.0f;
		}
	}


}
