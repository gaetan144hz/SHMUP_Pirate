using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHealth; //valeur de d�part assign�e � la vie
    private float currentHealth; //vie du joueur
    private bool canDamage;
    public TextMeshProUGUI healthText;
    public GameObject deathFX;
    public GameObject gameOverUI;
    public Gradient lifeGradient;
    public SpriteRenderer spritePlayer;

    private void Start()
    {
        currentHealth = maxHealth;
        spritePlayer.color = lifeGradient.Evaluate(currentHealth / maxHealth);
        healthText.text = currentHealth.ToString();
        canDamage = true;
    }

    public void TakeDamage(float damage) //fonction qui fait les d�gats
    {
        if (canDamage == true)
        {
            StartCoroutine(Damage(damage));
        }
        else if (canDamage == false)
        {
            currentHealth -= damage;
            spritePlayer.color = lifeGradient.Evaluate(currentHealth / maxHealth);
            healthText.text = currentHealth.ToString();
        }
        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
            Die();
        }
    }

    public void Heal(float heal) //fonction qui donne de la vie
    {
        for (int i = 0; i < heal; i++)
        {
            currentHealth++;
            spritePlayer.color = lifeGradient.Evaluate(currentHealth / maxHealth);
            if (currentHealth >= maxHealth) //si la vie d�passe la vie max
            {
                currentHealth = maxHealth;
            }
            healthText.text = currentHealth.ToString();
        }
    }

    public IEnumerator Damage(float damage)
    {
        canDamage = false;

        for (int i = 0; i < damage; i++)
        {
            currentHealth--;
            spritePlayer.color = lifeGradient.Evaluate(currentHealth / maxHealth);
            healthText.text = currentHealth.ToString();
            yield return new WaitForFixedUpdate();
        }

        canDamage = true;
        healthText.text = currentHealth.ToString();
        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
            Die();
        }
    }

    public void Die()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        gameOverUI.SetActive(true);
        Destroy(this.gameObject);
    }
}
