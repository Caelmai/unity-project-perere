using UnityEngine;
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

    #region LAYERS

    /// <summary>
    /// Player layer mask.
    /// </summary>
    public const string PlayerLayerMask = "Player";

    #endregion

    #region All (Variables)

    /// <summary>
    /// Update renderer effect time.
    /// </summary>
    public const float UpdateRendererEffectTime = 0.2f;

    #endregion

    #region Player (Variables)

    /// <summary>
    /// Player walk speed.
    /// </summary>
    public const float PlayerWalkSpeed = 2.5f, PlayerWalkAcaiBerryEffectSpeed = 5f;
    /// <summary>
    /// Player dash speed.
    /// </summary>
    public const float PlayerDashSpeed = 20f, PlayerDashAcaiBerryEffectSpeed = 30f;
    /// <summary>
    /// Player shot speed.
    /// </summary>
    public const float PlayerShotSpeed = 250f, PlayerShotCassavaEffectSpeed = 500f;
    /// <summary>
    /// Player initial shot damage;
    /// </summary>
    public const int PlayerInitialShotDamage = 1;
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
    /// Player invoke original renderer.
    /// </summary>
    public const float PlayerInvokeOriginalRenderer = 1.5f;

    #endregion

    #region Items (Variables)

    /// <summary>
    /// Açai berry effect time.
    /// </summary>
    public const float AcaiBerryEffectTime = 10f;
    /// <summary>
    /// Cassava effect time.
    /// </summary>
    public const float CassavaEffectTime = 10f;
    /// <summary>
    /// Guaraná healing hffect.
    /// </summary>
    public const int GuaranaHealingEffect = 1;

    #endregion

    #region Enemies (Variables)

    /// <summary>
    /// Enemy invoke original renderer.
    /// </summary>
    public const float EnemyInvokeOriginalRenderer = 0.5f;
    /// <summary>
    /// Enemy distance to reach player.
    /// </summary>
    public const float EnemyDistanceToReachTarget = 0.5f;

    /// <summary>
    /// Capelobo initial health.
    /// </summary>
    public const int CapeloboInitialHealth = 1;
    /// <summary>
    /// Capelobo trigger attack radius.
    /// </summary>
    public const float CapeloboTriggerAttackRadius = 10f;

    /// <summary>
    /// Arranca-línguas initial health.
    /// </summary>
    public const int ArracaLinguasInitialHealth = 1;
    /// <summary>
    /// Arranca-línguas trigger attack radius.
    /// </summary>
    public const float ArracaLinguasTriggerAttackRadius = 5f;
    /// <summary>
    /// Arranca-línguas walk speed.
    /// </summary>
    public const float ArracaLinguasWalkSpeed = 1.5f;

    #endregion
}