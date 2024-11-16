using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSysteme : MonoBehaviour {
	public GameObject character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (character.transform.position.x + 3.5f , -2.920526f,-10);
	}
}
