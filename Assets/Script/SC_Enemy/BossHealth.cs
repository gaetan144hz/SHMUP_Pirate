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
        componentDestroy();
    }

    public void componentDestroy()
    {
        Destroy(this.GetComponent<BossBullet>());
        Destroy(this.GetComponent<SpriteRenderer>());
        Destroy(this.GetComponent<Rigidbody2D>());
        Destroy(this.GetComponent<BoxCollider2D>());
        Destroy(this.GetComponent<EnemyPattern>());
    }
}