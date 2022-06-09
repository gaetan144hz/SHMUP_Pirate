using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerBullet : MonoBehaviour
{
    private PrincipalWeapon _principalWeapon;
    private Score _score;

    public GameObject dieVFX;
    public GameObject lastDieVFX;
    private Rigidbody2D rb;
    
    void Start()
    {
        _principalWeapon = FindObjectOfType<PrincipalWeapon>();
        rb = GetComponent<Rigidbody2D>();
        _score = FindObjectOfType<Score>();

        rb.velocity = transform.right * _principalWeapon.currentBulletSpeed;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        EnemyHealth enemyHealth = col.transform.GetComponent<EnemyHealth>();
        
        if (col.gameObject.CompareTag("limite"))
        {
            Die();
        }

        if (enemyHealth != null)
        {
            _score.scoreCount++;
            enemyHealth.TakeDamage(_principalWeapon.currentBulletDamage);
            Die();
        }
    }

    public void Die()
    {
        lastDieVFX = Instantiate(dieVFX, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
