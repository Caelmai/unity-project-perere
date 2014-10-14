using UnityEngine;
using System.Collections;

public class PlayerTarget : BaseScript
{
    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // Mouse position.
        Vector3 mousePosition = InputControl.GetMousePosition(transform.position, GameManager.Instance.MainCamera);

        // Set target position.
        transform.position = mousePosition;

        // Enforce target renderer inside of screen.
        transform.EnforceBounds(GameManager.Instance.MainCamera, renderer);
    }
}
