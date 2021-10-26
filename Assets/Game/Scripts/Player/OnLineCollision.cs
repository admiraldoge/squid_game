using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLineCollision : MonoBehaviour
{
    private PlayerController _playerController;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("CurrentPlayer");
        _playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "StartLine")
        {
            _playerController.inField = true;
            Debug.Log("Player entered game");
        }
        else if(collision.collider.name == "EndLine")
        {
            //_playerController.inField = !_playerController.inField;
            _playerController.inField = false;
            _playerController.makePlayerWin();
            Debug.Log("Player pass to next round");
        }
    }
}
