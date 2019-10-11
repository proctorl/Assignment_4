using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownLives : MonoBehaviour
{
    List<string> Lives = new List<string>() { "Lives", "1", "2", "3", "4", "5" };

    public Dropdown dropdown;
    public static int myIndex;
    public static int lives;

    public void Dropdown_IndexChanged(int index)
    {
        myIndex = index;
        lives = index;
    }

    private void Update()
    {
        if (myIndex == 0)
        {
            myIndex = 1;
          
        }
        if (lives == 0)
        {
            lives = 1;

        }


    }
    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(Lives);
    }
}
