using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    private Text _endGameMessage;

    private RawImage _bloodImage;
    // Start is called before the first frame update
    void Start()
    {
        GameObject message = GameObject.Find("EndGameMessage");
        GameObject blood = GameObject.Find("BloodImage");
        _endGameMessage = message.GetComponent<Text>();
        _bloodImage = blood.GetComponent<RawImage>();
        _bloodImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showLoseMessage()
    {
        _endGameMessage.text = "Perdiste";
        _endGameMessage.color = Color.white;
        _bloodImage.enabled = true;
    }

    public void showWinMessage()
    {
        _endGameMessage.text = "Pasaste a la siguiente ronda";
        _endGameMessage.color = new Color(75,181,77) ;
    }
}
