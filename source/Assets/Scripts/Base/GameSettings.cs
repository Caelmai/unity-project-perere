using UnityEngine;
using System.Collections;

public static class GameSettings
{
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