using UnityEngine;
using System.Collections;

public static class InputControl
{
    /// <summary>
    /// Check if dash is enabled.
    /// </summary>
    /// <returns>Returns if dash is enabled.</returns>
    public static bool IsDashEnabled
    {
        get
        {
            return Input.GetButtonDown(GameSettings.DashEnabled);
        }
    }

    /// <summary>
    /// Get movement.
    /// </summary>
    /// <returns>Returns a vector with 1 or -1 to both axis.</returns>
    public static Vector2 GetMovement(Vector2 speed)
    {
        return new Vector2
        (
            Input.GetAxis(GameSettings.HorizontalMovement) * speed.x,
            Input.GetAxis(GameSettings.VerticalMovement) * speed.y
        );
    }
}
