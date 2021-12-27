using GameCreator.Core;
using GameCreator.Melee;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public CharacterMelee characterMelee;
    public MeleeWeapon sword;

    public Actions punchActions;
    public Actions kickActions;

    public GameModel gameModel;

    public UnityEvent onKilled;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwingWeapon();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StabWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Punch();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Kick();
        }
    }

    private void Kick()
    {
        kickActions.Execute();
    }

    private void Punch()
    {
        punchActions.Execute();
    }

    private void StabWeapon()
    {
        characterMelee.Execute(CharacterMelee.ActionKey.B);
    }

    private void SwingWeapon()
    {
        characterMelee.Execute(CharacterMelee.ActionKey.A);
    }

    [ContextMenu("Equip Sword")]
    private void EquipSword()
    {
        Debug.Log("Equipping Sword");
        StartCoroutine(characterMelee.Draw(sword));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MonsterAttack"))
        {
            gameModel.playerHp -= gameModel.monsterAttackDamage;

            if (gameModel.playerHp <= 0)
            {
                onKilled?.Invoke();
            }
        }
    }
}