using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PrincipalWeapon : MonoBehaviour
{
    public float playerBulletSpeed;
    public float playerBulletDamage;

    [HideInInspector] public float currentBulletSpeed;
    [HideInInspector] public float currentBulletDamage;

    [SerializeField] private GameObject bouletPrefab;
    public Transform[] firepoint;

    [SerializeField] private float cooldown;
    public bool canShoot = true;

    void Start()
    {
        currentBulletDamage = playerBulletDamage;
        currentBulletSpeed = playerBulletSpeed;
    }

    void Update()
    {
        
    }

    public void OnShoot(InputValue value)
    {
        if (value.isPressed && canShoot == true)
        {
            Instantiate(bouletPrefab, firepoint[0].position, firepoint[0].rotation);
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
