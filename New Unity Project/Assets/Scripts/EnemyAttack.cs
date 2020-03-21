using System;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class EnemyAttack : Interactable
{
    public GameObject player;
    public CharacterStats myStats;

    public void Start()
    {
        player = GameObject.Find("Player");
        myStats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = player.GetComponent<CharacterCombat>();
        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }
}