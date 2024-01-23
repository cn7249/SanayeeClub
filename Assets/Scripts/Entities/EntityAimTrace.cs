using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAimTrace : MonoBehaviour
{
    public SpriteRenderer characterRenderer;

    private GameCharacterController _controller;

    void Awake()
    {
        _controller = GetComponent<GameCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 aimDirection)
    {
        FlipSprite(aimDirection);
    }

    private void FlipSprite(Vector2 direction)
    {
        float theta = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (Mathf.Abs(theta) > 90)
        {
            characterRenderer.flipX = true;
        }
        else
        {
            characterRenderer.flipX = false;
        }
    }
    
}
