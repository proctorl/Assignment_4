using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;
    public static int highScore;
    public Text text;
   

    public void Update()
    {
        if (PinCount > highScore)
            highScore = PinCount;

        text.text = PinCount.ToString();
        
    }


}
