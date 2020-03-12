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
        //enemy.destination = character.transform.position;
        //Call Navmesh agent to start attacking player when in the same area
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
        Instantiate(sparkEffect, transform.position, Quaternion.identity);
        Debug.Log("damage Taken");
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}