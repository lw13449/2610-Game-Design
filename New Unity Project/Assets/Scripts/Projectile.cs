using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    public Transform player;
    private Vector3 target;
    public PlayerStats playerHealth;

    public void Start()
    {
        player = GameObject.Find("Player").transform;
        target = new Vector3(player.position.x, player.position.y);
    }

    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
            playerHealth.TakeDamage(30);
        }
    }

    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}