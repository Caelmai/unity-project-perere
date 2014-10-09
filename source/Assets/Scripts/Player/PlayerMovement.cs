using UnityEngine;
using System.Collections;

public class PlayerMovement : BaseScript
{
    #region Fields

    /// <summary>
    /// Player movement.
    /// </summary>
    private Vector2 movement;
    /// <summary>
    /// Is dash enabled?
    /// </summary>
    private bool isDashEnabled;

    /// <summary>
    /// Current walk speed.
    /// </summary>
    private float currentWalkSpeed;

    /// <summary>
    /// Current dash speed.
    /// </summary>
    private float currentDashSpeed;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        SetDefaultSpeed();
    }

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
            movement = InputControl.GetMovement(currentDashSpeed);
        }
        else
        {
            // Walk movement.
            movement = InputControl.GetMovement(currentWalkSpeed);
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

    /// <summary>
    /// To increase speed when use a açaí berry item.
    /// </summary>
    public void IncreaseSpeed()
    {
        currentWalkSpeed = GameSettings.PlayerWalkAcaiBerryEffectSpeed;
        currentDashSpeed = GameSettings.PlayerDashAcaiBerryEffectSpeed;

        Invoke("SetDefaultSpeed", GameSettings.AcaiBerryEffectTime);
    }

    /// <summary>
    /// To decrease speed when finish açaí berry item effect.
    /// </summary>
    private void SetDefaultSpeed()
    {
        currentWalkSpeed = GameSettings.PlayerWalkSpeed;
        currentDashSpeed = GameSettings.PlayerDashSpeed;
    }

    #endregion
}
