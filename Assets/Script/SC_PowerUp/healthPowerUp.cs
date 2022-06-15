using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPowerUp : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private PlayerHealth _playerHealth;

    [SerializeField] private float healIncrease;
    
    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
        
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = -transform.right * speed;
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (_playerHealth != null)
        {
            _playerHealth.Heal(healIncrease);
            Destroy(this.gameObject,0.1f);
        }
    }
}
