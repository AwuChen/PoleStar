using UnityEngine;
using System.Collections;

public class Plane_Movement : MonoBehaviour {
	public float speed = 85.0f;

	// Use this for initialization
	void Start () {
		Debug.Log ("plane pilot script added to: " + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;
		float bias = 0.5f;
		Camera.main.transform.position = Camera.main.transform.position * bias +
			moveCamTo * (1.0f-bias); 
		Camera.main.transform.LookAt (transform.position + transform.forward * 30.0f );

		transform.position += transform.forward * Time.deltaTime * speed;// * 90.0f;

		speed -= transform.forward.y * Time.deltaTime * 50.0f;

		if (speed < 15.0f) {
			speed = 15.0f;
		}
		//rotate right or left top or bottom 
		transform.Rotate ( -Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
		//speed increase or decrease  
		 
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		//terrain deterrance 
		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position );

		if (terrainHeightWhereWeAre > transform.position.y) {
			//make it explode
			transform.position = new Vector3 (transform.position.x,
			                                 terrainHeightWhereWeAre, 
			                                 transform.position.z);
			}
		}
}
