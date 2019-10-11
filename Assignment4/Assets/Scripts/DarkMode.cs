using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkMode : MonoBehaviour
{
    public SpriteRenderer BGlight;
    public SpriteRenderer BGdark;
    public SpriteRenderer Clight;
    public SpriteRenderer CDark;
    public SpriteRenderer Logolight;
    public SpriteRenderer LogoDark;

    public static bool DarkModeOn = false;


    private void Awake()
    {
        BGlight.enabled = true;
        Clight.enabled = true;
        Logolight.enabled = true;

        BGdark.enabled = false;
        CDark.enabled = false;
        LogoDark.enabled = false;

        
    }

    public void Toggle_Changed(bool value)
    {
        if (value == false)
        {
            DarkModeOn = false;
            lightModeSelectio();
        }
        else if (value == true)
        {
            DarkModeSelectio();
            DarkModeOn = true;
        }

    }
    public void lightModeSelectio()
    {
        BGlight.enabled = true;
        Clight.enabled = true;
        Logolight.enabled = true;

        BGdark.enabled = false;
        CDark.enabled = false;
        LogoDark.enabled = false;

        
    }

    public void DarkModeSelectio()
    {
        BGlight.enabled = false;
        Clight.enabled = false;
        Logolight.enabled = false;

        BGdark.enabled = true;
        CDark.enabled = true;
        LogoDark.enabled = true;

        

        
    }

    
}
