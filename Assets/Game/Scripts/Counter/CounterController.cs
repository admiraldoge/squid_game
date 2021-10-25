using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterController : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    private GameObject[] players;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        players = GameObject.FindGameObjectsWithTag("player");
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                killAllPlayers();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    void killAllPlayers()
    {
        for (int i = 0; i < players.Length; i++)
        {
            PlayerController playerController = players[i].GetComponent<PlayerController>();
            Debug.Log("Killing player"+i);
            playerController.killPlayer();
        }
    }
}
