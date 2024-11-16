using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {


	public int baseScorePoint = 1;
	public int multiplier = 1;
	private int currentScore = 0;
	private int highScore;

	// Use this for initialization
	void Start () {
		currentScore = 0;
		highScore = PlayerPrefs.GetInt("HighScore");
		StartCoroutine("Scoring");

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void UpdateScore (int scoreToAdd){
		currentScore += scoreToAdd*multiplier;
		gameObject.GetComponent<Text>().text = currentScore + "";
	}


	private IEnumerator Scoring(){


		while(true){
			UpdateScore(baseScorePoint);
			yield return new WaitForSeconds(0.1f);
			if(currentScore > highScore){
				gameObject.GetComponent<Text>().color = new Color(1f, 0.93f, 0);
			}

		}
	}
}
