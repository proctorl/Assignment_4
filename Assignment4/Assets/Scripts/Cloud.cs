using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Vector2 MoveDirection { get { return m_moveDirection; } }

    public Vector2 ScaleRange = new Vector2(0.25f, 1);
    public Vector2 SpeedRange = new Vector2(0.025f, 0.05f);


    public float MaxLife = 3;

    private Vector2 m_moveDirection = Vector2.zero;
    private float moveSpeed;

    
    public void Initialize()
    {
        // Randomzie speed and scale
        m_moveDirection = new Vector2(-1, 0);
        moveSpeed = Random.Range(SpeedRange.x, SpeedRange.y);

        float scale = Random.Range(ScaleRange.x, ScaleRange.y);
        transform.localScale = new Vector2(scale, scale);
    }

   

    void FixedUpdate()
    {
        Vector3 move = m_moveDirection * moveSpeed;
        transform.position += move;
    }
}
