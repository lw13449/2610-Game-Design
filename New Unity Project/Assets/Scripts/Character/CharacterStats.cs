using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; set; }
    public Stat damage;
    public Stat shield;
    public Image healthBar;

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
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        //This subtracts the defense of the shield
        damage -= shield.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        
        //takes damage
        currentHealth -= damage;
        healthBar.fillAmount = currentHealth;
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

    public void BoostHealth()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            currentHealth = maxHealth;
            healthBar.fillAmount = currentHealth;
        }
    }
}