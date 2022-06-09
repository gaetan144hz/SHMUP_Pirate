using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    
    private Rigidbody2D rb;
    
    public GameObject dieVFX;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerHealth playerHealth = col.transform.GetComponent<PlayerHealth>(); // je recupere d'abord la vie du player pour ensuite l'utilisé après
        
        if (playerHealth != null) // != lorsque que je collisione avec quelque chose je verifie la condition SEULEMENT SI l'object avec lequel on à colisioné contient "playerHealth" 
        {
            playerHealth.TakeDamage(damage); // je recupère le script "playerHealth" et je vais chercher dedans la fonction "TakeDamage", je lui assige entre () les damages causés par la balle de l'ennemi
            Die(); // je détruit la balle ennemi avec la fonction Die si dessous
        }

        if (col.CompareTag("limite"))
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(dieVFX, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
