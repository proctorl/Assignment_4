using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gamehasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;
    public void EndGame()
    {
        if (gamehasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gamehasEnded = true;
        
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
