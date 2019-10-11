using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public Text text;
    public Text lives;

    public void Update()
    {
        text.text = PlayerName.ShowName + "\nLives:" + DropdownLives.myIndex.ToString();
        
    }
}
