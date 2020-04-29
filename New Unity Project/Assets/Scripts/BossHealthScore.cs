using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthScore : MonoBehaviour
{
    public CharacterStats boss;
    //public FloatData healthValue;

    private Text health;

    public void Start()
    {
        health = GetComponent<Text>();
    }

    public void Update()
    {
        health.text = "BOSS HEALTH " + boss.currentHealth;

    }
}