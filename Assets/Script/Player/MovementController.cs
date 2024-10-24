using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;
    private Vector2 movementInput;
    
    void getInput() 
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));    
    }
    
    void Update()
    {
        getInput();
        transform.Translate(movementInput * (movementSpeed * Time.deltaTime));    
    }
}
