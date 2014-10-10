using UnityEngine;
using System.Collections;

public static class InputControl
{
    /// <summary>
    /// Check if dash is enabled.
    /// </summary>
    public static bool IsDashEnabled
    {
        get
        {
            return Input.GetButtonDown(GameSettings.DashEnabled);
        }
    }

    /// <summary>
    /// Check if shot is enabled.
    /// </summary>
    public static bool IsShotEnabled
    {
        get
        {
            return Input.GetButtonDown(GameSettings.ShotEnabled);
        }
    }

    /// <summary>
    /// Get movement.
    /// </summary>
    /// <param name="speed">The speed.</param>
    /// <returns>Returns a vector with 1 or -1 to both axis.</returns>
    public static Vector2 GetMovement(float speed)
    {
        return new Vector2
        (
            Input.GetAxis(GameSettings.HorizontalMovement) * speed,
            Input.GetAxis(GameSettings.VerticalMovement) * speed
        );
    }

    /// <summary>
    /// Get world mouse position.
    /// </summary>
    /// <param name="CameraShake.MainCamera">Main camera.</param>
    /// <returns>Returns world mouse position.</returns>
    public static Vector3 GetMousePosition(Vector3 position, Camera mainCamera)
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = position.z - mainCamera.transform.position.z;
        mousePosition = mainCamera.ScreenToWorldPoint(mousePosition);

        return mousePosition;
    }
}
