using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAnimations : MonoBehaviour
{
    protected Animator animator;
    protected GameCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<GameCharacterController>();
    }

}