using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour {
	public GameObject[] waves;	
	// Use this for initialization
	void Start () {
		SpawnWave();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnWave(){


		Instantiate(waves[Random.Range(0,waves.Length)], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,0), Quaternion.identity);


	}

}
