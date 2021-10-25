using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip song0;
    public AudioClip song20;
    public AudioClip song30;
    public AudioClip song50;
    public AudioClip song80;
    public AudioClip song100;
    public AudioClip song120;
    public AudioClip song150;
    public AudioClip song180;
    public AudioClip killSong;
    
    private AudioClip[] songs = new AudioClip[9];

    private AudioSource _audioSource;
    private int musicIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        songs[0] = song0;
        songs[1] = song20;
        songs[2] = song30;
        songs[3] = song50;
        songs[4] = song80;
        songs[5] = song100;
        songs[6] = song120;
        songs[7] = song150;
        songs[8] = song180;
        _audioSource = GameObject.Find("DollSong").GetComponent<AudioSource>();
        //_audioSource.clip = songs[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateSong(int index)
    {
        _audioSource.clip = songs[index];
        _audioSource.Play();
    }
    
    public void stopSong()
    {
        _audioSource.Stop();
    }

    public void setKillSong()
    {
        _audioSource.clip = killSong;
        _audioSource.Play();
    }

    public void setMute(Boolean value)
    {
        _audioSource.mute = value;
    }
}
