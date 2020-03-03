using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public float lookRadius = 10f;
    private Transform target;

    private Animator anim;
    public GameObject sparkEffect;
    //public float attackPause;
    //public float startAttackPause;
    public NavMeshAgent enemy;
    public GameObject character;
    

    public void Start()
    {
        target = character.transform;
        character = GameObject.Find("Player");
        enemy = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        float distance = Vector3.Distance(character.transform.position, transform.position);
        //enemy.destination = character.transform.position;
        //Call Navmesh agent to start attacking player when in the same area
        //Perhaps it doesn't need a script for this
        //But will need for the scripting underneath
        if (distance <= lookRadius)
        {
            enemy.SetDestination(target.position);
        }

        if (distance <= enemy.stoppingDistance)
        {
            //Attack the target
            FaceTarget();
        }
        
        //if (attackPause <= 0)
        //{
        //    speed = 5;
        //}
        //else
        //{
        //    speed = 0;
        //    attackPause = startAttackPause;
        //}
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        //transform.Translate(Vector2.left *speed*Time.deltaTime);
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
        Instantiate(sparkEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damage Taken");
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}