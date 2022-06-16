using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    
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
        Destroy(this.gameObject);
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
