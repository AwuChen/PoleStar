using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {
	public bool move = false; 
	public GameObject directionObj; 
	public float x,y,z; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(move) 
		{ 				
			transform.position += new Vector3(x,y,z);       
		}
			
	}
	void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
	
}
