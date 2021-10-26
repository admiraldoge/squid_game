using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGameStatus : MonoBehaviour
{
    private GameController _gameController;
    private MessageController _messageController;
    private PlayerController _playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameStatus = GameObject.Find("Utils");
        GameObject player = GameObject.Find("CurrentPlayer");
        GameObject message = GameObject.Find("EndGameMessage");
        _messageController = message.GetComponent<MessageController>();
        _gameController = gameStatus.GetComponent<GameController>();
        _playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerGameStatus();
    }

    Boolean checkPlayerGameStatus()
    {
        //Debug.Log(gameController);
        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && _gameController.isRedLight && _playerController.inField)
        {
            //_messageController.showLoseMessage();
            _playerController.inField = false;
            _playerController.killPlayer();
        }
        return true;
    }
}
