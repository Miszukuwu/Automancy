using System;
using UnityEngine;

namespace Script.Player
{
    public class AnimationController : MonoBehaviour
    {
        private readonly int _horizontalMovement = Animator.StringToHash("HorizontalMovement");
        private readonly int _verticalMovement = Animator.StringToHash("VerticalMovement");
        private readonly int _movement = Animator.StringToHash("Movement");
        
        private Animator animator;
        private MovementController movementController;
        private SpriteRenderer spriteRenderer;
        
        void Start()
        {
            animator = GetComponent<Animator>();
            movementController = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            animator.SetFloat(_horizontalMovement, Math.Abs(movementController.MovementInput.x)); 
            animator.SetFloat(_verticalMovement, movementController.MovementInput.y);
            animator.SetFloat(_movement, movementController.MovementInput.sqrMagnitude);
            if (movementController.MovementInput.x < 0) {
                spriteRenderer.flipX = true;
            } else if (movementController.MovementInput.x > 0) {
                spriteRenderer.flipX = false;
            }
        }

        
    }
}