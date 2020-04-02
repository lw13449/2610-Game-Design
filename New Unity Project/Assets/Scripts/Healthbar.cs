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
        float healthPercentage = player.currentHealth / player.maxHealth;
        healthBarImage.transform.localScale =
            new Vector3(Mathf.Clamp(healthPercentage, 0f, 1f), healthBarImage.transform.localScale.y, healthPercentage);
        //healthBarImage.fillAmount = healthPercentage;
    }
}