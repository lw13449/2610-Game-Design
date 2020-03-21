using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public int enemyDamage;
    public CharacterAttack attack;

    public void Start()
    {
        enemyDamage = attack.damage;
    }

    public void OnTriggerEnter(Collider other)
    {
        DealDamage(other.gameObject);
    }

    public void DealDamage(GameObject other)
    {
        if (other.GetComponent<EnemyController>())
        {
            other.GetComponent<EnemyController>().TakeDamage(enemyDamage);
        }
    }
}
