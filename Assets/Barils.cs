using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barils : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerHealth _playerHealth;
    public float speed;
    public int barilDamage;
    
    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = -transform.up * speed;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _playerHealth.TakeDamage(barilDamage);
            Destroy(this.gameObject);
        }
    }
}
