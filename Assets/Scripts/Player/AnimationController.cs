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
        private InputReceiver inputReceiver;
        private SpriteRenderer spriteRenderer;
        private Vector2 movementInput => inputReceiver.MovementInput;
        
        void Start()
        {
            animator = GetComponent<Animator>();
            inputReceiver = GameObject.FindGameObjectWithTag("Player").GetComponent<InputReceiver>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            animator.SetFloat(_horizontalMovement, Math.Abs(movementInput.x)); 
            animator.SetFloat(_verticalMovement, movementInput.y);
            animator.SetFloat(_movement, movementInput.sqrMagnitude);
            if (movementInput.x < 0) {
                spriteRenderer.flipX = true;
            } else if (movementInput.x > 0) {
                spriteRenderer.flipX = false;
            }
        }

        
    }
}