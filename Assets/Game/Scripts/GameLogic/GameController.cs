using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public Boolean isRedLight = true;
    public float nextActionTime = 0.0f;
    public float period = 0.1f;
    public MusicController _audioSource;

    private double[] gameRounds = new double[9];

    private int roundIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject audio = GameObject.Find("DollSong");
        _audioSource = audio.GetComponent<MusicController>();
        //gameRounds[0] = {4.598, 3.84, 3.553,  3.082, 2.56, 2.325, 2.115, 1.933, 1.802 };
        gameRounds[0] = 4.598;
        gameRounds[1] = 3.84;
        gameRounds[2] = 3.553;
        gameRounds[3] = 3.082;
        gameRounds[4] = 2.56;
        gameRounds[5] = 2.325;
        gameRounds[6] = 2.115;
        gameRounds[7] = 1.933;
        gameRounds[8] = 1.802;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime )
        {
            isRedLight = !isRedLight;
            Debug.Log("IsRedLight? "+isRedLight);
            if (isRedLight)
            {
                nextActionTime += 5;
                _audioSource.stopSong();
                Debug.Log("Cannot move! for 5 secs");
            }
            else
            {
                //int gameRound = Random.Range(10, 20);
                float gameRound = (float)gameRounds[roundIndex];
                roundIndex = (roundIndex + 1) % 9;
                Debug.Log("Game round lasts "+gameRound);
                nextActionTime += gameRound;
                //_audioSource.setMute(false);
                _audioSource.updateSong(roundIndex);
                Debug.Log("Can move!");
            }
            // execute block of code here
        }

    }
    
    
}
