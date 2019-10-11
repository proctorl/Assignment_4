using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour
{
    public SpriteRenderer BGlight;
    public SpriteRenderer BGdark;
    public SpriteRenderer Clight;
    public SpriteRenderer CDark;
    public SpriteRenderer Logolight;
    public SpriteRenderer LogoDark;

    public bool darkMode;
    public bool lightMode;
    public void lightModeSelectio()
    {
        BGlight.enabled = true;
        Clight.enabled = true;
        Logolight.enabled = true;

        BGdark.enabled = false;
        CDark.enabled = false;
        LogoDark.enabled = false;

        lightMode = true;
        darkMode = false;
    }

    public void DarkModeSelectio()
    {
        BGlight.enabled = false;
        Clight.enabled = false;
        Logolight.enabled = false;

        BGdark.enabled = true;
        CDark.enabled = true;
        LogoDark.enabled = true;

        darkMode = true;
        lightMode = false;
        Debug.Log("Herere");
    }

    public void Update() {
        if (DarkMode.DarkModeOn)
        {
            DarkModeSelectio();
            Debug.Log("DMON");
        }
        else 
            lightModeSelectio();
    }
public void MainMenu()
    {
        Score.PinCount = 0;
        SceneManager.LoadScene("MainMenu");
        
    }

    public void ExitGame()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        Update();
        
            
    }
    public void HighScores()
    {
        SceneManager.LoadScene("HighScores");
        Update();
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");

        Update();
       
    }

    public void PlayAgain()
    {
        Debug.Log(DropdownLives.lives);
        DropdownLives.myIndex = DropdownLives.lives;
        Score.PinCount = 0;
        SceneManager.LoadScene("Game");
    }

  



}
