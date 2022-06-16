using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float health;

    public GameObject victoireUI;
    public GameObject deathFX;
    
    public Color colorOnHit;
    private SpriteRenderer sprite;
    private bool canPlay;
    
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
        canPlay = true;
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
        
        if(canPlay == true)
        {
            StartCoroutine(PlayDamage());
        }
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
    
    public IEnumerator PlayDamage()
    {
        canPlay = false;
        var baseColor = sprite.color;
        sprite.color = colorOnHit;
        yield return new WaitForSeconds(0.2f);
        sprite.color = baseColor;
        canPlay = true;
    }
}