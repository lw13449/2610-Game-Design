using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class PlayerStats : CharacterStats
{
    public GameObject respawnPoint;
    public GameObject healthUIOne;
    public GameObject healthUITwo;
    
    public override void Die()
    {
        base.Die();
        //death animation
        //audio for death
        //respawn
        KillPlayer();
        
    }
    public void KillPlayer()
    {
        TakeAwayHeart();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TakeAwayHeart()
    {
        if (healthUIOne == false)
        {
            healthUITwo.gameObject.SetActive(false);
        }
        else
        {
            healthUIOne.gameObject.SetActive(false);
        }

        if (healthUITwo == false)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnReset()
    {
        GetComponent<CharacterControls>().enabled = false;
        gameObject.transform.position = respawnPoint.transform.position;
        GetComponent<CharacterControls>().enabled = true;

        GetComponent<CharacterStats>().currentHealth = maxHealth;
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        respawnPoint = newSpawn;
    }
}