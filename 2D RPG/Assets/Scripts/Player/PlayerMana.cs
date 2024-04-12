﻿using UnityEngine;

public class PlayerMana:MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public void UseMana(float amount)
    {
        if (stats.Mana >= amount)
        {
            stats.Mana = Mathf.Max(stats.Mana - amount, 0f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            UseMana(1f);
        }
    }
}