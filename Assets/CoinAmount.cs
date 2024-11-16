using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinAmount : MonoBehaviour {


	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().text = "0" ;
		//gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "" ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SaveCoins(){
		int coinsAlreadyCollected = PlayerPrefs.GetInt("CoinsAmount");
		PlayerPrefs.SetInt("CoinsAmount", coinsAlreadyCollected + int.Parse(gameObject.GetComponent<Text>().text));
	}

}
