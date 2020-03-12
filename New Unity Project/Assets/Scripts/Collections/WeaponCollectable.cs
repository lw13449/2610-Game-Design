using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponCollectable : Collectable
{
    public UnityEvent useEvent;
    public Animator characterAnim;
    public float enemyHealth;
    public GameObject obj;

    public override void Use()
    {
        useEvent.Invoke();
    }

    public void Equip()
    {
        obj.SetActive(true);
    }

    public void Defend()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            characterAnim.SetTrigger("Defend");
            //negates the damage the enemy throws at Player
        }
    }

    public void Attack()
    {
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            characterAnim.SetTrigger("Attack");
            Debug.Log("Strike");
            //Damage to enemy health = 1
        }
    }

    public void HammerSmash()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            characterAnim.SetTrigger("Smash");
            Debug.Log("Smash");
            //Damage to enemy health = 2
        }
    }

    public void FuryAttack()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            characterAnim.SetTrigger("Fury Attack");
            Debug.Log("Fury Attack");
            //Damage to enemy health = 3
        }
    }
}