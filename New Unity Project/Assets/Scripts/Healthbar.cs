using System;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public PlayerStats player;
    public Image healthBarImage;

    public void Start()
    {
        player = GetComponent<PlayerStats>();
    }

    public void Update()
    {
        // ReSharper disable once PossibleLossOfFraction
        float healthPercentage = player.currentHealth / player.maxHealth;
        healthBarImage.fillAmount = healthPercentage;
    }
}