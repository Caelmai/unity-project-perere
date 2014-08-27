using UnityEngine;
using System.Collections;

public class PlayerMovement : ScriptBase
{
    #region Fields

    /// <summary>
    /// Walk speed.
    /// </summary>
    public Vector2 walkSpeed = Vector2.one;
    /// <summary>
    /// Dash speed.
    /// </summary>
    public Vector2 dashSpeed = Vector2.one;

    /// <summary>
    /// Player movement.
    /// </summary>
    private Vector2 movement;
    /// <summary>
    /// Is dash enabled?
    /// </summary>
    private bool isDashEnabled;

    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        if (InputControl.IsDashEnabled)
        {
            movement = InputControl.GetMovement(dashSpeed);
        }
        else
        {
            movement = InputControl.GetMovement(walkSpeed);
        }
    }

    /// <summary>
    /// Update game physikcs.
    /// </summary>
    void FixedUpdate()
    {
        if (!InputControl.IsDashEnabled)
        {
            rigidbody2D.velocity = movement;
        }
    }

    #endregion
}
