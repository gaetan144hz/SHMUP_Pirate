using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    public float health;
    
    public GameObject deathFX;
    private GameObject gameOverUI;

    private void Awake()
    {
        //gameOverUI = FindObjectOfType<GameOver>();
    }

    void Start()
    {
        //gameOverUI.SetActive(false);
        health = 100f;
    }

    void Update()
    {
        healthText.text = health.ToString();

        if (health <= 0) 
        {
            //gameOverUI.SetActive(true);
            Die();
        }
    }

    public void TakeDamage(float enemyDamage)
    {
        health -= enemyDamage;
        healthText.text = health.ToString();
    }

    public void Die()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
