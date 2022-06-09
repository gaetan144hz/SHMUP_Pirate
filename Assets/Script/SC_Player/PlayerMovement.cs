using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Vector2 movement;
    private Controllers playerInput;
    private Rigidbody2D rb;
    
    public static List<PlayerMovement> playerList = new List<PlayerMovement>();
    public static List<PlayerMovement> GetPlayerList()
    {
        return playerList;
    }

    private void Awake()
    {
        playerList.Add(this);
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    #region Movement

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
        rb.velocity = movement * speed;
    }
    
    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    #endregion
    
}
