using System;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public CharacterStats player;
    public Image healthBarImage;

    public void Start()
    {
        player = GetComponent<CharacterStats>();
    }

    public void Update()
    {
        var healthPercentage = player.currentHealth / player.maxHealth;
        healthBarImage.fillAmount = healthPercentage;
    }
}