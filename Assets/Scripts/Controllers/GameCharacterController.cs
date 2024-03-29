using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    protected CharacterStatsHandler Stats { get; private set; }

    protected virtual void Awake()
    {
        Stats = GetComponent<CharacterStatsHandler>();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}