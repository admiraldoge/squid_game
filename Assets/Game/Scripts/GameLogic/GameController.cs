using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public Boolean isRedLight = true;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime )
        {
            int gameRound = Random.Range(10, 20);
            Debug.Log("Game round lasts "+gameRound);
            nextActionTime += gameRound;
            isRedLight = !isRedLight;
            if (isRedLight)
            {
                Debug.Log("Cannot move!");
            }
            else
            {
                Debug.Log("Can move!");
            }
            // execute block of code here
        }
        
    }
    
}
