using System;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public CharacterStats bossStats;
    public float lookRadius;
    private Transform target;

    private Animator anim;
    public GameObject player;
    public GameObject lastDoorSwitch;

    public CharacterCombat combat;

    public void Start()
    {
        target = player.transform;
        player = GameObject.Find("Player");
        combat = GetComponent<CharacterCombat>();
    }

    public void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        
        if (distance <= lookRadius)
        {
            CharacterStats targetStats = target.GetComponent<CharacterStats>();
            if (targetStats != null)
            {
                combat.Attack(targetStats);
            }
            FaceTarget();
        }
        if (bossStats.currentHealth <= 0)
        {
            Destroy(gameObject);
            lastDoorSwitch.SetActive(true);
        }
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
        bossStats.currentHealth -= damage;
    }
}