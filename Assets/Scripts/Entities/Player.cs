using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    public GameObject penguin;
    public GameObject wizard;

    private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<PlayerCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnLookEvent += OnAim;
        if(PlayerPrefs.GetString("UserCharacter") == "Penguin")
        {
            //Æë±Ï ÄÑ±â
            penguin.SetActive(true);
            characterRenderer = penguin.GetComponent<SpriteRenderer>();
        }
        else if(PlayerPrefs.GetString("UserCharacter") == "Wizard")
        {
            wizard.SetActive(true);
            characterRenderer = wizard.GetComponent<SpriteRenderer>();
        }
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }
    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(rotZ >= 90f && rotZ < 180f)
        {
            characterRenderer.flipX = true;
        }
        else if(rotZ >= 0f && rotZ < 90f)
        {
            characterRenderer.flipX = false;
        }
        else if(rotZ >= 180f && rotZ < 270f)
        {
            characterRenderer.flipX = true;
        }
        else if(rotZ >= 270f && rotZ < 360f)
        {
            characterRenderer.flipX = false;
        }
    }
}
