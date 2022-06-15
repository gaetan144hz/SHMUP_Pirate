using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float health;

    public GameObject victoireUI;
    
    public GameObject deathFX;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) 
        {
            Die();
        }
    }
    
    public void TakeDamage(float playerDamage)
    {
        health -= playerDamage;
    }

    public void Die()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        victoireUI.SetActive(true);
        Destroy(this.gameObject);
    }
}