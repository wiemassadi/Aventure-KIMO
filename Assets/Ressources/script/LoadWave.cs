using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("WavePoint")){
			GameObject.Find("StartWavePoint").GetComponent<WaveSpawn>().SpawnWave();
		}
	}
}
