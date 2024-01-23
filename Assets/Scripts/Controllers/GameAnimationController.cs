using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class GameAnimationController : GameAnimations
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    public GameObject player;
    public GameObject knightSprite;
    public GameObject wizardSprite;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        CheckCharacterType(GameManager.I.PlayerType);
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f);
    }

    private void CheckCharacterType(int num)
    {
        ChangePlayerSprite(num);
        ChangeAnimator(num);
        ChangeAimSpriteRenderer(num);
    }

    private void ChangeAnimator(int num)
    {
        animator = player.GetComponentInChildren<Animator>();
    }

    private void ChangePlayerSprite(int num)
    {
        switch (num)
        {
            case (int)GameManager.CharacterType.Knight:
                knightSprite.SetActive(true);
                wizardSprite.SetActive(false);
                break;
            case (int)GameManager.CharacterType.Wizard:
                wizardSprite.SetActive(true);
                knightSprite.SetActive(false);
                break;
        }
    }

    private void ChangeAimSpriteRenderer(int num)
    {
        switch (num)
        {
            case (int) GameManager.CharacterType.Knight:
                player.GetComponent<EntityAimTrace>().characterRenderer = knightSprite.GetComponent<SpriteRenderer>();
                break;
            case (int) GameManager.CharacterType.Wizard:
                player.GetComponent<EntityAimTrace>().characterRenderer = wizardSprite.GetComponent<SpriteRenderer>();
                break;
        }
    }
}