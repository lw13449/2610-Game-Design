﻿﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

 //[RequireComponent(typeof())]
public class CharacterAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPosition;
    public float attackRange;
    public LayerMask whatIsEnemy;
    public int damage;
    public Animator characterAnim;
    public void Update()
    {
        if (timeBtwAttack <= 0)
        {
            //attack
            if (Input.GetKeyDown(KeyCode.X))
            {
                characterAnim.SetTrigger("Attack");
                

                //Collider[] enemiesToDamage = Physics.OverlapSphere(attackPosition.position, attackRange, whatIsEnemy);
                //for (int i = 0; i < enemiesToDamage.Length; i++)
                //{
                //    Debug.Log("Player Attacks");
                //    enemiesToDamage[i].GetComponent<EnemyController>().TakeDamage(damage);
                //}
                
                timeBtwAttack = startTimeBtwAttack;
            }
            
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, attackRange);
    }
}
