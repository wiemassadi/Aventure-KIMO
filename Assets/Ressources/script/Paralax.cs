using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paralax : MonoBehaviour {


	private float length;
	private float startPosition;
	public GameObject cam;
	public float paralaxIntensity;
	// Use this for initialization
	void Start () {
		startPosition = gameObject.transform.position.x;
		length = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
	}
	
	void FixedUpdate()
	{
		float temp = cam.transform.position.x * (1-paralaxIntensity);
		float distance = cam.transform.position.x * paralaxIntensity;
		gameObject.transform.position = new Vector3(startPosition + distance, gameObject.transform.position.y, gameObject.transform.position.z);
		if(temp > (startPosition+length)){
			startPosition += length*2 -1; 
		}
	}
}
