using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	 
	public GameObject directionObj; 
	public float x,y,z; 
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {				
		      
	}

	void moveUp() 
	{ 
		transform.position += new Vector3(0,4,0); 
	}



	void OnTriggerEnter(Collider other) 
	{ 
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{ 
			print("one"); 
			moveUp (); 
		}
		print("one"); 
		moveUp (); 

	}
}
