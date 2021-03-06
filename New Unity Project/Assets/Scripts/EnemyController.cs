﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //public int health;
    public CharacterStats enemyStats;
    public float speed;
    public float lookRadius = 10f;
    private Transform target;

    private Animator anim;
    public GameObject sparkEffect;
    public NavMeshAgent enemy;
    public GameObject character;

    public CharacterCombat combat;


    public void Start()
    {
        target = character.transform;
        character = GameObject.Find("Player");
        enemy = GetComponent<NavMeshAgent>();
        combat = GetComponent<CharacterCombat>();
    }

    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        
        if (distance <= lookRadius)
        {
            enemy.SetDestination(target.position);
        }

        if (distance <= enemy.stoppingDistance)
        {
            CharacterStats targetStats = target.GetComponent<CharacterStats>();
            if (targetStats != null)
            {
                combat.Attack(targetStats);
            }
            FaceTarget();
        }

        if (enemyStats.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left *speed*Time.deltaTime);
    }

    public void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime*5f);
    }

    public void TakeDamage(int damage)
    {
        //noise for attack when they take damage
        //Instantiate(sparkEffect, transform.position, Quaternion.identity);
        Debug.Log("damage Taken");
        enemyStats.currentHealth -= damage;
    }
}