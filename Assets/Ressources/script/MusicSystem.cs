using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSystem : MonoBehaviour {
	 public AudioSource music;
    public AudioSource[] sounds;

	// Use this for initialization
	void Start () {
		music.volume = PlayerPrefs.GetFloat("MusicVolume");
        foreach(AudioSource sound in sounds){
            sound.volume = PlayerPrefs.GetFloat("SoundVolume");
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
