using UnityEngine;
using System.Collections;

public static class GameSettings
{
    #region Player (Variables)

    /// <summary>
    /// Player initial health.
    /// </summary>
    public const float PlayerInitialHealth = 1;
    /// <summary>
    /// Player walk speed.
    /// </summary>
    public const float PlayerWalkSpeed = 5;
    /// <summary>
    /// Player dash speed.
    /// </summary>
    public const float PlayerDashSpeed = 20;
    /// <summary>
    /// Player shot speed.
    /// </summary>
    public const float PlayerShotSpeed = 500f;

    #endregion

    #region TAGS

    /// <summary>
    /// The player tag.
    /// </summary>
    public const string PlayerTag = "Player";

    #endregion

    #region AXES

    /// <summary>
    /// Horizontal input axis.
    /// </summary>
    public const string HorizontalMovement = "Horizontal";
    /// <summary>
    /// Vertical input axis.
    /// </summary>
    public const string VerticalMovement = "Vertical";
    /// <summary>
    /// Dash enabled.
    /// </summary>
    public const string DashEnabled = "Dash";
    /// <summary>
    /// Shot enabled.
    /// </summary>
    public static string ShotEnabled = "Shot";

    #endregion
}