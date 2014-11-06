using UnityEngine;
using System.Collections;

/// <summary>
/// CHASER!
/// </summary>
public class CapeloboBehavior : EnemyBehavior
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Method to initialize variables.
    /// </summary>
    protected override void Initilize()
    {
        currentStatus = EnemyStatus.Idle;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
    }

    /// <summary>
    /// Detect collision hit.
    /// </summary>
    protected override void OnCollisionHit(Collision2D collision, EnemyStatus nextStatus)
    {
    }

    /// <summary>
    /// Method to evaluate enemy status.
    /// </summary>
    protected override void EvaluateEnemyStatus()
    {
    }

    /// <summary>
    /// Method to implement enemy status behavior.
    /// </summary>
    protected override void UpdateCurrentEnemyStatus()
    {
    }

    #endregion
}