using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ConfigManager : MonoBehaviour {
	 public GameObject musicSlider;
    public GameObject soundSlider;
    public AudioSource music;
    public AudioSource[] sounds;



	// Use this for initialization
	void Start () {
		  if(PlayerPrefs.GetFloat("MusicVolume") != 0f){
            musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");
        }
        if(PlayerPrefs.GetFloat("SoundVolume") != 0f){
            soundSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("SoundVolume");
        }

	}
	public void setMusic(){
		float volume = musicSlider.GetComponent<Slider>().value;
        
       if(music != null){
           music.volume = volume;
        }
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }


    public void setSounds(){
		float volume = soundSlider.GetComponent<Slider>().value;
        foreach (AudioSource sound in sounds)
        {
            sound.volume = volume;
        }
        PlayerPrefs.SetFloat("SoundVolume", volume);
    }

	

	// Update is called once per frame
	void Update () {
		
	}
}
