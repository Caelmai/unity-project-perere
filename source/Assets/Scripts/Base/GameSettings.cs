﻿using UnityEngine;
using System.Collections;

public static class GameSettings
{
    #region TAGS

    /// <summary>
    /// Player tag.
    /// </summary>
    public const string PlayerTag = "Player";
    /// <summary>
    /// Enemy shot tag.
    /// </summary>
    public const string PlayerShotTag = "PlayerShot";
    /// <summary>
    /// Enemy tag.
    /// </summary>
    public const string EnemyTag = "Enemy";
    /// <summary>
    /// Enemy shot tag.
    /// </summary>
    public const string EnemyShotTag = "EnemyShot";
    /// <summary>
    /// Item tag.
    /// </summary>
    public const string ItemTag = "Item";
    /// <summary>
    /// Gold tag.
    /// </summary>
    public static string GoldTag = "Gold";

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
    public const string ShotEnabled = "Shot";

    #endregion

    #region Player (Variables)

    /// <summary>
    /// Player walk speed.
    /// </summary>
    public const float PlayerWalkSpeed = 5f, PlayerWalkAcaiBerryEffectSpeed = 7.5f;
    /// <summary>
    /// Player dash speed.
    /// </summary>
    public const float PlayerDashSpeed = 20f, PlayerDashAcaiBerryEffectSpeed = 30f;
    /// <summary>
    /// Player shot speed.
    /// </summary>
    public const float PlayerShotSpeed = 1000f;
    /// <summary>
    /// Player initial shot damage;
    /// </summary>
    public const int PlayerInitialShotDamage = 1;
    /// <summary>
    /// Player time to recover.
    /// </summary>
    public const float PlayerTimeToRecover = 1f;
    /// <summary>
    /// Player initial health.
    /// </summary>
    public const int PlayerInitialHealth = 5;
    /// <summary>
    /// Player collision against enemies.
    /// </summary>
    public const int PlayerCollisionAgainstEnemies = 1;
    /// <summary>
    /// Player kickback when shot.
    /// </summary>
    public const float PlayerKickbackShot = 100f;
    /// <summary>
    /// Player recover changer timer.
    /// </summary>
    public const int PlayerRecoverChangerTimer = 5;

    #endregion

    #region Items (Variables)

    /// <summary>
    /// Açai berry effect time.
    /// </summary>
    public const float AcaiBerryEffectTime = 5f;

    /// <summary>
    /// 
    /// </summary>
    public const int GuaranaHealingEffect  = 1;

    #endregion

    #region Enemies (Variables)

    /// <summary>
    /// Capelobo initial health.
    /// </summary>
    public const int CapeloboInitialHealth = 1;

    #endregion
}