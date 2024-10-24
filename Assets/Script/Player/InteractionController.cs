using UnityEngine;
using UnityEngine.Serialization;

namespace Script.Player
{
    public class InteractionController : MonoBehaviour 
    {
        [SerializeField] private float interactionReach = 1.0f;
        
        private bool isInteractPressed;
        
        /// <summary>
        /// Gets the player's input for interaction.
        /// </summary>
        void getInput()
        {
            isInteractPressed = Input.GetButtonDown("Interact");
        }
        
        private void Update()
        {
            getInput();
            if (isInteractPressed) {
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
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, interactionReach, layerMask);
            
            if (hit.collider == null) {
                Debug.Log("Didn't hit anything");
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