using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    public bool moveUp;

    [Header("Range")] 
    [SerializeField] private float rangeUp;
    [SerializeField] private float rangeDown;
    
    void Start()
    {
        moveUp = true;
    }

    void Update()
    {
        if (transform.position.y > rangeUp)
        {
            moveUp = false;
        }else if (transform.position.y < rangeDown)
        {
            moveUp = true;
        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime); //ATTENTION au -- moins

        }
    }
}
