using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuHUD : MonoBehaviour {
	public GameObject CoinPanel;
	public GameObject HighScorePanel;
	public GameObject confPanel;
	private bool isConf = false;



	// Use this for initialization
	void Start () {
		CoinPanel.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
		HighScorePanel.GetComponent<Text>().text = PlayerPrefs.GetInt("HighScore") + "";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ConfigDisplay(){
		if(isConf){
			isConf = false;
			confPanel.SetActive(false);
		}
		else{
			isConf = true;
			confPanel.SetActive(true);
		}
	}

}
