using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    private CounterController _counterController;
    private DollController _dollController;
    public Boolean isRedLight = true;
    public float nextActionTime = 0.0f;
    public float period = 0.1f;
    public MusicController _audioSource;
    public Boolean gameStarted = false;
    public Boolean gameStartedAlready = false;
    public Double phaseError = 0.5;

    private double[] gameRounds = new double[9];

    private int roundIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject audio = GameObject.Find("DollSong");
        GameObject counter = GameObject.Find("Counter");
        GameObject doll = GameObject.Find("DollHead");
        _dollController = doll.GetComponent<DollController>();
        _counterController = counter.GetComponent<CounterController>();
        _audioSource = audio.GetComponent<MusicController>();
        //gameRounds[0] = {4.598, 3.84, 3.553,  3.082, 2.56, 2.325, 2.115, 1.933, 1.802 };
        gameRounds[0] = 4.598 + phaseError;
        gameRounds[1] = 3.84 + phaseError;
        gameRounds[2] = 3.553 + phaseError;
        gameRounds[3] = 3.082 + phaseError;
        gameRounds[4] = 2.56 + phaseError;
        gameRounds[5] = 2.325 + phaseError;
        gameRounds[6] = 2.115 + phaseError;
        gameRounds[7] = 1.933 + phaseError;
        gameRounds[8] = 1.802 + phaseError;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            if (gameStartedAlready)
            {
                //_counterController.setTimeRemainder(75);
                gameStartedAlready = false;
            }
            if (Time.time > nextActionTime )
            {
                isRedLight = !isRedLight;
                Debug.Log("IsRedLight? "+isRedLight);
                _dollController.rotateHead();
                if (isRedLight)
                {
                    nextActionTime += 5;
                    _audioSource.stopSong();
                    _audioSource.setKillSong();
                    Debug.Log("Cannot move! for 5 secs");
                }
                else
                {
                    //int gameRound = Random.Range(10, 20);
                    float gameRound = (float)gameRounds[roundIndex];
                    _audioSource.updateSong(roundIndex);
                    if(roundIndex != 8) roundIndex = (roundIndex + 1) % 9;
                    Debug.Log("Game round lasts "+gameRound);
                    nextActionTime += gameRound;
                    //_audioSource.setMute(false);
                    Debug.Log("Can move!");
                }
                // execute block of code here
            }
        }
        else
        {
            nextActionTime += 10;
            gameStarted = true;
            //_counterController.setTimeRemainder(10);
        }

    }
    
    
}
