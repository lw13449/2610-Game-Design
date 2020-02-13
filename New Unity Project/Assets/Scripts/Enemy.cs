using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    private Animator anim;
    public GameObject sparkEffect;
    public float attackPause;
    public float startAttackPause;
    

    public void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //they should ignore the update scripts for movement 
        //until the player comes within their area and 
        //initiate their attack for NavMesh towards
        //the player
    }

    public void Update()
    {
        //Call Navmesh agent to start attacking player when in the same area
        //Perhaps it doesn't need a script for this
        //But will need for the scripting underneath
        if (attackPause <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            attackPause = startAttackPause;
        }
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        //transform.Translate(Vector2.left *speed*Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        //noise for attack when they take damage
        Instantiate(sparkEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damage Taken");
    }
}