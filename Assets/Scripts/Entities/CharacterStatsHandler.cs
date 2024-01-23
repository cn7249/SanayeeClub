using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{

    [SerializeField] private CharacterStats baseStats;
    public CharacterStats CurrentStates { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();


    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        CurrentStates = new CharacterStats();
        CurrentStates.statsChangeType = baseStats.statsChangeType;
        CurrentStates.name = baseStats.name;
        CurrentStates.maxHealth = baseStats.maxHealth;
        CurrentStates.speed = baseStats.speed;

        CheckNameIsNull();

    }

    private void CheckNameIsNull()
    {
        if (GameManager.I.PlayerName != null)
        {
            CurrentStates.name = GameManager.I.PlayerName;
        }
    }
}