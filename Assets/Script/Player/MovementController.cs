using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[SelectionBase]
public class MovementController : MonoBehaviour
{
    
    [SerializeField] private float movementSpeed = 5.0f;
    private Vector2 movementInput;
    private Rigidbody2D playerRb;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    
    void getInput()
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));    
    }
    
    void Update()
    {
        getInput();
    }

    private void FixedUpdate() 
    {
        playerRb.velocity = movementInput.normalized * (movementSpeed * Time.fixedDeltaTime);
    }
    
}
