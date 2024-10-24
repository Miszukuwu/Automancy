using UnityEngine;

namespace Script.Player
{
    public class InteractionController : MonoBehaviour 
    {
        [SerializeField] private float reach = 1.0f;
        
        private bool interactButton;
        
        void getInput()
        {
            interactButton = Input.GetButtonDown("Interact");
        }
        
        private void Update()
        {
            getInput();
            if (interactButton) {
                Debug.Log("Interact button pressed");
                Interact();
            }
        }

        private void Interact()
        {
            int layerMask = LayerMask.GetMask("Interactable");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, reach, layerMask);
            if (hit.collider == null) {
                Debug.Log("Didnt hit anything");
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