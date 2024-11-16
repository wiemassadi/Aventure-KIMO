using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanvasManager : MonoBehaviour {


	public GameObject pauseBtn;
	
	public GameObject pausePanel;
	public GameObject ConfPanel;
	public GameObject scorePan;
	public GameObject gameOverPanel;
	
	public GameObject coinPanelTxt;
	public GameObject scoreGoTxt;
	public GameObject gameOverCoinTxt;
	private bool isPause = false;
	private bool isConf = false;
	public GameObject highScore;
	public Transform initPos;
	public Transform confPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GameOver(){
		GameObject.Find("Music").GetComponent<AudioSource>().Stop();
		GameObject.Find("LoseSound").GetComponent<AudioSource>().Play(0);
		

		Time.timeScale = 0;
		gameOverPanel.SetActive(true);
		scorePan.SetActive(false);
		pauseBtn.SetActive(false);
		coinPanelTxt.GetComponent<CoinAmount>().SaveCoins();
		gameOverCoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
		scoreGoTxt.GetComponent<Text>().text = scorePan.transform.Find("ScoreTxt").GetComponent<Text>().text;
		if(int.Parse(scoreGoTxt.GetComponent<Text>().text) > PlayerPrefs.GetInt("HighScore")){
			highScore.SetActive(true);
			scoreGoTxt.GetComponent<Text>().color = new Color(1f,0.93f,0f);
			PlayerPrefs.SetInt("HighScore",int.Parse(scoreGoTxt.GetComponent<Text>().text));
		}

	}
	
	public void PausePlay(){
		if(isPause){
			isPause = false;
			isConf = false;
			Time.timeScale = 1;
			pauseBtn.SetActive(true);
			pausePanel.SetActive(false);
			ConfPanel.SetActive(false);
		}
		else{
			isPause = true;
			Time.timeScale = 0;
			pauseBtn.SetActive(false);
			pausePanel.SetActive(true);
		}
	}
public void ConfDisplay(){
		if(isConf){
			isConf = false;
			pausePanel.transform.position = new Vector3(initPos.position.x, pausePanel.transform.position.y, pausePanel.transform.position.z);
			ConfPanel.SetActive(false);
		}
		else{
			isConf = true;
			pausePanel.transform.position = new Vector3(confPos.position.x, pausePanel.transform.position.y, pausePanel.transform.position.z);
			ConfPanel.SetActive(true);
		}

}
	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene("scene1");
	}
}
