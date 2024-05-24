using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // Hide and lock the cursor at the start of the game
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // If the player presses the Escape key, unlock and show the cursor
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
        // If the player clicks the mouse, lock and hide the cursor again
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}