using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    int value = DropdownValue.myIndex;

    private void Difficulty()
    {
        if (value == 1 || value == 0)
            speed = 75f;
        if (value == 2)
            speed = 125f;
        if (value == 3)
            speed = 175f;
        if (value == 4)
            speed = 225f;
        if (value == 5)
            speed = 275f;
    }
    private void Update()
    {
        Difficulty();
        transform.Rotate(0f,0f, speed * Time.deltaTime);
    }
}
