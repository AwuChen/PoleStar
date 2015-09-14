using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
	
	public GameObject Spaceship; 
	public string levelname; 
	public bool switchCamera = false; 
	//GameObject[] spaceships; 	
	//ArrayList spaceships = new ArrayList(); 
	GameObject[] spaceships; 
	GameObject[] shipCamera; 
	 
	// Use this for initialization
	void Start () {
		//List<transform> abc = new List<transform>();  
		spaceships = GameObject.FindGameObjectsWithTag("Spaceship");  
		shipCamera = GameObject.FindGameObjectsWithTag ("SpaceShipCamera"); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	
	GameObject findClosestSpaceShip(GameObject[] closests) 
	{ 
		GameObject tMin = null;
		float minDist = Mathf.Infinity;
		Vector3 currentPos = transform.position;
		foreach (GameObject t in closests)
		{
			float dist = Vector3.Distance(t.transform.position, currentPos);
			if (dist < minDist)
			{
				tMin = t;
				minDist = dist;
			}
		}
		return tMin;
	}

	GameObject findClosestSpaceShipCamera(GameObject[] closests) 
	{ 
		GameObject tMin = null;
		float minDist = Mathf.Infinity;
		Vector3 currentPos = transform.position;
		foreach (GameObject t in closests)
		{
			float dist = Vector3.Distance(t.transform.position, currentPos);
			if (dist < minDist)
			{
				tMin = t;
				minDist = dist;
			}
		}
		return tMin;
	}

	GameObject target; 
	GameObject targetCamera; 
	void OnTriggerEnter(Collider other) 
	{ 
		//Application.LoadLevel(levelname);
		target = findClosestSpaceShip(spaceships); 
		targetCamera = findClosestSpaceShipCamera (shipCamera); 
		GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = false; 
		targetCamera.GetComponent<Camera>().enabled = true; 	
		target.GetComponent<ShipMovement>().move = true; 
		GameObject.FindGameObjectWithTag("Player").transform.parent=target.transform; 

		
	} 
	
}
