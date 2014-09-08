using UnityEngine;
using System.Collections;

public class PlayerMovement : BaseScript
{
    #region Fields

    /// <summary>
    /// Walk speed.
    /// </summary>
    public float walkSpeed;
    /// <summary>
    /// Dash speed.
    /// </summary>
    public float dashSpeed;

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

            PlayerDashTrails.Self.Dash();
        }
        else
        {
            // Walk movement.
            movement = InputControl.GetMovement(walkSpeed);
        }

        // Enforce player inside the screen.
        transform.EnforceBounds(mainCamera, renderer);
    }

    /// <summary>
    /// Update game physikcs.
    /// </summary>
    void FixedUpdate()
    {
        // Movement through rigidbody.
        rigidbody2D.velocity = movement;
    }

    #endregion
}
