using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthNumberScript : MonoBehaviour
{
    public PlayerStats player;
    //public FloatData healthValue;

    private Text health;

    public void Start()
    {
        health = GetComponent<Text>();
    }

    public void Update()
    {
        health.text = "HEALTH " + player.currentHealth;
        
        if (player.currentHealth <= 60)
        {
            health.color = Color.yellow;
        }
        if (player.currentHealth <= 30)
        {
            health.color = Color.red;
        }
    }
}