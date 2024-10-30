using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script.Player
{
    [RequireComponent(typeof(InputReceiver))]
    public class InteractionController : MonoBehaviour 
    {
        [SerializeField] private float interactionReach = 1.0f;
        private InputReceiver inputReceiver;

        private void Start()
        {
            inputReceiver = GetComponent<InputReceiver>();
        }

        private bool isInteractPressed {
            get { return inputReceiver.isInteractPressed; }
        }
        private Vector2 currentDirection {
            get { return inputReceiver.currentDirection; }
        }
        private void Update()
        {
            if (isInteractPressed && !GameManager.isUiOpen) {
                Debug.Log("Interact button pressed");
                Interact();
            }
        }

        /// <summary>
        /// Shoots a raycast to check for interactable objects and calls their Interact method.
        /// Currently only checks for objects to the right of the player.
        /// </summary>
        private void Interact()
        {
            int layerMask = LayerMask.GetMask("Interactable");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, currentDirection, interactionReach, layerMask);
            
            if (hit.collider == null) {
                Debug.Log("Didn't hit anything");
                Debug.Log(currentDirection);
                return;
            }
            
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if (interactable == null) {
                Debug.Log("Not interactable");
                return;
            }
            
            interactable.Interact();
        }
    }
}