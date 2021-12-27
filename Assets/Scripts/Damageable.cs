using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Damageable : MonoBehaviour
{
    public int hp = 100;

    public int punchDamage = 2;
    public int kickDamage = 2;
    public int weaponDamage = 2;
    public int laserDamage = 2;

    public Slider hpSlider;

    public UnityEvent<GameObject> onKilled;

    private void Update()
    {
        hpSlider.value = hp;

        if (hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} Dead");
        onKilled?.Invoke(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fist"))
        {
            hp -= punchDamage;
        }

        if (other.CompareTag("Kick"))
        {
            hp -= punchDamage;
        }

        if (other.CompareTag("Weapon"))
        {
            hp -= weaponDamage;
        }
    }
}