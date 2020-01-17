using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public void OnTriggerEnter(Collider other)
    {
        GetComponent<Health>()
        {
            Destroy(player.gameObject);
        }
    }
}
