using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLineController : MonoBehaviour
{
    private GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void killAllPlayers()
    {
        for (int i = 0; i < players.Length; i++)
        {
            PlayerController playerController = players[i].GetComponent<PlayerController>();
            Debug.Log("Killing player"+i);
            playerController.alive = false;
        }
    }
}
