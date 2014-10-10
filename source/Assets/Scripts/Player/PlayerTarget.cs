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
        Vector3 mousePosition = InputControl.GetMousePosition(transform.position, CameraShake.MainCamera);

        // Set target position.
        transform.position = mousePosition;

        // Enforce target renderer inside of screen.
        transform.EnforceBounds(CameraShake.MainCamera, renderer);
    }
}
