using UnityEngine;
using System.Collections;

public class PlayerMovement : BaseScript
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
        // If dash button is pressed.
        if (InputControl.IsDashEnabled)
        {
            // TODO
            // 1. DASH sem lado selecionado, ele se movimenta para trás, ou seja, ao contrário do último lado.
            // 2. Utilizar o LERP/SLERP para o DASH.
            // 3. Para testar o DASH, preciso da animação final ou placeholder.
            movement = InputControl.GetMovement(dashSpeed);
        }
        else
        {
            // Walk movement.
            movement = InputControl.GetMovement(walkSpeed);
        }
    }

    /// <summary>
    /// Update game physikcs.
    /// </summary>
    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }

    #endregion
}
