using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(InputReceiver))]
[SelectionBase]
public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;
    private Vector2 movementInput {
        get { return inputReceiver.MovementInput; }
    }

    private Rigidbody2D playerRb;
    private InputReceiver inputReceiver;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        inputReceiver = GetComponent<InputReceiver>();
    }
    
    private void FixedUpdate()
    {
        playerRb.linearVelocity = movementInput.normalized * (movementSpeed * Time.fixedDeltaTime);
    }
}