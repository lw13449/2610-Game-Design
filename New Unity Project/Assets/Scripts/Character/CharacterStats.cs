using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; set; }
    public Stat damage;
    //public Stat shield;

    public Stat furyAttack;

    public Stat smash;
    public Animator characterAnim;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Start()
    {
        //if (healthBar != null) healthBar.SetMaxHealth(maxHealth);
    }

    public void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        //This subtracts the defense of the shield
        if (Input.GetKey(KeyCode.C))
        {
            damage -= damage;
            damage = Mathf.Clamp(damage, 0, int.MaxValue);
        }
        //damage = Mathf.Clamp(damage, 0, int.MaxValue);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Hammer Smash");
            damage += smash.GetValue();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fury Attack");
            damage += furyAttack.GetValue();
        }
        
        //takes damage
        currentHealth -= damage;
        //Change the player color when they are hit;
        characterAnim.SetTrigger("TakeDamage");
        //healthBar.fillAmount = currentHealth;
        Debug.Log(transform.name + "takes" + damage + "damage.");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //Die in some way
        //death animation
        //respawn at the starting position or last save
        Debug.Log(transform.name + "died.");
    }

    public void MotherboardPlugIn()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            BoostHealth();
        }
    }

    public void BoostHealth()
    {
        currentHealth = maxHealth;
//        if (Input.GetKeyDown(KeyCode.K))
//        {
//            currentHealth = maxHealth;
//        }
    }
}