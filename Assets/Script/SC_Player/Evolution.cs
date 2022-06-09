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
    }

    void Update()
    {
        
    }

    public void onEvol()
    {
        if (_score.scoreCount == toEvo2)
        {
            _spriteRenderer.sprite = niv2;
            _principalWeapon.currentBulletDamage += damageNiv2;
            Debug.Log(_principalWeapon.currentBulletDamage);
        }

        if (_score.scoreCount == toEvo3)
        {
            _spriteRenderer.sprite = niv3;
            _principalWeapon.currentBulletDamage += damageNiv3;
            Debug.Log(_principalWeapon.currentBulletDamage);
        }
    }
}
