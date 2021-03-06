﻿using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCoolDown = 0f;
    
    private CharacterStats myStats;
    public float attackDelay = 1f;

    public event System.Action OnAttack;

    public void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    public void Update()
    {
        attackCoolDown -= Time.deltaTime;
    }
    
    public void Attack(CharacterStats targetStats)
    {
        if (attackCoolDown <= 0f)
        {
            StartCoroutine(DoDamage(targetStats, attackDelay));
            
            if (OnAttack != null)
            {
                OnAttack();
            }
            attackCoolDown = 1f / attackSpeed;
        }
    }

    IEnumerator DoDamage(CharacterStats stats, float delay)
    {
        yield return new WaitForSeconds(delay);
        stats.TakeDamage(myStats.damage.GetValue());
    }
}