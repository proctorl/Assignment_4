using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    public Text playerScore;
    public Text highScore;

    public void Update()
    {
        highScore.text = PlayerName.ShowName + "'s Score: " + Score.PinCount.ToString();
        playerScore.text = "High Score: " + Score.highScore.ToString();
    }
}
