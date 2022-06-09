using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spell : MonoBehaviour
{
    [SerializeField] private GameObject spellPrefab;
    public Transform[] firepoint;

    [SerializeField] private float cooldown;
    public bool canShoot = true;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void OnSpell(InputValue value)
    {
        if (value.isPressed && canShoot == true)
        {
            Instantiate(spellPrefab, firepoint[0].position, firepoint[0].rotation);
            Instantiate(spellPrefab, firepoint[1].position, firepoint[1].rotation);
            Instantiate(spellPrefab, firepoint[2].position, firepoint[2].rotation);
            StartCoroutine(shootBool());
        }
        else
        {
            return;
        }
    }

    IEnumerator shootBool()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
