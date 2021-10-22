using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGameStatus : MonoBehaviour
{
    private GameController _gameController;

    private Text _endGameMessage;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameStatus = GameObject.Find("Utils");
        GameObject message = GameObject.Find("EndGameMessage");
        _endGameMessage = message.GetComponent<Text>();
        _gameController = gameStatus.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerGameStatus();
    }

    Boolean checkPlayerGameStatus()
    {
        //Debug.Log(gameController);
        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && _gameController.isRedLight)
        {
            _endGameMessage.text = "Perdiste";
            _endGameMessage.color = Color.red;
        }
        return true;
    }
}
