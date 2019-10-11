using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    private bool isHit = false;
    private int counter;


    public  AudioSource thump;
    public float speed = 20f;
    public Rigidbody2D rb;


    private void Awake()
    {
        thump.Pause();
    }
    private void Update()
    {
       
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pin")
        {
            isHit = true;
            if (isHit == true)
                DropdownLives.myIndex--;
            if (DropdownLives.myIndex > 0)
                SceneManager.LoadScene("Game");
            else
                SceneManager.LoadScene("GameOver");
            
            
        }
        else if (collision.tag == "Rotator")
        {
            thump.Play();
            if (isHit != true)
                Score.PinCount++;
            transform.SetParent(collision.transform);
            isPinned = true;
        }

        

    }
}
