using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public Stat shield;

    //public HealthBar healthBar;

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
        damage -= shield.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        
        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage.");
        if (currentHealth <= 0)
        {
            Die();
        }
        //healthBar.SetHealth(currentHealth);
    }

    public virtual void Die()
    {
        //Die in some way
        //death animation
        //respawn at the starting position or last save
        Debug.Log(transform.name + "died.");
    }
    
}