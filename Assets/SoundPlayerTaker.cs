using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayerTaker : MonoBehaviour
{
    public GameObject soundsPrefab;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(soundsPrefab, transform.position, transform.rotation);
        }
    }
}
