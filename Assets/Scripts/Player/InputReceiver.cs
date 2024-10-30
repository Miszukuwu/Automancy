using UnityEngine;

public class InputReceiver : MonoBehaviour
{
    public bool isInteractPressed { get; private set; }
    public Vector2 MovementInput { get; private set; }
    public Vector2 currentDirection { get; private set; }
    /// <summary>
    /// Gets the player's movement input from the Input system.
    /// </summary>
    void getInput()
    {
        MovementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (MovementInput != Vector2.zero) {
            currentDirection = MovementInput;
        }
        isInteractPressed = Input.GetButtonDown("Interact");
    }
    void Update()
    {
        getInput();
    }
}
