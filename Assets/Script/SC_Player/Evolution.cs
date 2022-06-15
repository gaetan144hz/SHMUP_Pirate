using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    private PrincipalWeapon _principalWeapon;
    private Score _score;
    private SpriteRenderer _spriteRenderer;

    [Header("Evolution Cap")]
    public int toEvo2;
    public int toEvo3;
    public bool canEvolve2;
    public bool canEvolve3;
    
    [Header("Evolution Bateau")]
    public Sprite niv1;
    public Sprite niv2;
    public Sprite niv3;

    [Header("DamageIncrease")] 
    public int damageNiv2;
    public int damageNiv3;

    private void Awake()
    {
        _principalWeapon = GetComponent<PrincipalWeapon>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _score = GetComponent<Score>();
    }

    void Start()
    {
        _spriteRenderer.sprite = niv1;
        canEvolve2 = true;
        canEvolve3 = true;
    }

    void Update()
    {
        if (_score.scoreCount == toEvo2 && canEvolve2 == true)
        {
            onEvolve2();
        }

        if (_score.scoreCount == toEvo3 && canEvolve3 == true)
        {
            onEvolve3();
        }
        else
        {
            return;
        }
    }

    public void onEvolve2()
    {
        _spriteRenderer.sprite = niv2;
        _principalWeapon.currentBulletDamage += damageNiv2;
        canEvolve2 = false;
        Debug.Log(_principalWeapon.currentBulletDamage);
        
    }

    public void onEvolve3()
    {
        _spriteRenderer.sprite = niv3;
        _principalWeapon.currentBulletDamage += damageNiv3;
        canEvolve3 = false;
        Debug.Log(_principalWeapon.currentBulletDamage);
    }
}
